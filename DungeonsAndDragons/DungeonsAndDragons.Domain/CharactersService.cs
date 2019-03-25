using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DungeonsAndDragons.Base.Identifier;
using DungeonsAndDragons.Domain.Contracts;
using DungeonsAndDragons.Domain.Models.Commands.Characters;
using DungeonsAndDragons.Domain.Models.Responses;
using DungeonsAndDragons.Entities;
using DungeonsAndDragons.Persistence.Contracts;

namespace DungeonsAndDragons.Domain
{
    public class CharactersService : ICharactersService
    {
        private readonly ICharactersRepository<ObjectIdentifier> _charactersRepository;
        private readonly ICommandValidator<CreateCharacterCommand, Character> _createCommandValidator;
        private readonly ICommandValidator<UpdateCharacterCommand, Character> _updateCommandValidator;
        private readonly IObjectIdentifierParser _objectIdentifierParser;
        private readonly IMapperAdapter _mapperAdapter;

        public CharactersService(
            ICharactersRepository<ObjectIdentifier> charactersRepository,
            ICommandValidator<CreateCharacterCommand, Character> createCommandValidator,
            ICommandValidator<UpdateCharacterCommand, Character> updateCommandValidator,
            IObjectIdentifierParser objectIdentifierParser,
            IMapperAdapter mapperAdapter)
        {
            _charactersRepository = charactersRepository ?? throw new ArgumentNullException(nameof(charactersRepository));
            _createCommandValidator = createCommandValidator ?? throw new ArgumentNullException(nameof(createCommandValidator));
            _updateCommandValidator = updateCommandValidator ?? throw new ArgumentNullException(nameof(updateCommandValidator));
            _objectIdentifierParser = objectIdentifierParser ?? throw new ArgumentNullException(nameof(objectIdentifierParser));
            _mapperAdapter = mapperAdapter ?? throw new ArgumentNullException(nameof(mapperAdapter));
        }

        public async Task<IReadOnlyCollection<CharacterResponse>> GetAllAsync()
        {
            var characters = await _charactersRepository.GetAllAsync();
            return _mapperAdapter.Map<IReadOnlyCollection<CharacterResponse>>(characters);
        }

        public async Task<CharacterResponse> GetByIdAsync(string id)
        {
            var characterId = _objectIdentifierParser.ValidateAndParse(id);
            var character = await _charactersRepository.GetAsync(characterId);

            if (character == null)
            {
                return null;
            }

            return _mapperAdapter.Map<Character, CharacterResponse>(character);
        }

        public async Task<CharacterResponse> CreateAsync(CreateCharacterCommand createCommand)
        {
            _createCommandValidator.ValidateAndThrowIfFailed(createCommand);

            var character = _mapperAdapter.Map<CreateCharacterCommand, Character>(createCommand);
            var createdCharacter = await _charactersRepository.SaveAsync(character);

            return _mapperAdapter.Map<Character, CharacterResponse>(createdCharacter);
        }

        public async Task<CharacterResponse> UpdateAsync(UpdateCharacterCommand updateCommand)
        {
            var characterId = _objectIdentifierParser.ValidateAndParse(updateCommand.Id);
            var existingCharacter = await _charactersRepository.GetAsync(characterId);

            if (existingCharacter == null)
            {
                return null;
            }

            _updateCommandValidator.ValidateAndThrowIfFailed(updateCommand);

            var character = _mapperAdapter.Map<UpdateCharacterCommand, Character>(updateCommand);
            var updatedCharacter = await _charactersRepository.SaveAsync(character);

            return _mapperAdapter.Map<Character, CharacterResponse>(updatedCharacter);
        }

        public async Task DeleteAsync(string id)
        {
            var characterId = _objectIdentifierParser.ValidateAndParse(id);
            await _charactersRepository.DeleteAsync(characterId);
        }
    }
}

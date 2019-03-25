using System.Collections.Generic;
using System.Threading.Tasks;
using DungeonsAndDragons.Domain.Models.Commands.Characters;
using DungeonsAndDragons.Domain.Models.Responses;

namespace DungeonsAndDragons.Domain.Contracts
{
    public interface ICharactersService
    {
        Task<IReadOnlyCollection<CharacterResponse>> GetAllAsync();

        Task<CharacterResponse> GetByIdAsync(string id);

        Task<CharacterResponse> CreateAsync(CreateCharacterCommand createCommand);

        Task<CharacterResponse> UpdateAsync(UpdateCharacterCommand updateCommand);

        Task DeleteAsync(string id);
    }
}

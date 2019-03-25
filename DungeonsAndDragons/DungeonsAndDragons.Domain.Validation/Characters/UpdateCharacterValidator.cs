using FluentValidation;
using DungeonsAndDragons.Domain.Contracts;
using DungeonsAndDragons.Domain.Models.Commands.Characters;
using DungeonsAndDragons.Entities;
using DungeonsAndDragons.Persistence.Contracts;
using DungeonsAndDragons.Base.Identifier;
using DungeonsAndDragons.Persistence.Specifications.Characters;

namespace DungeonsAndDragons.Domain.Validation.Characters
{
    public class UpdateCharacterValidator : AbstractValidator<UpdateCharacterCommand>, ICommandValidator<UpdateCharacterCommand, Character>
    {
        public UpdateCharacterValidator(ICharactersRepository<ObjectIdentifier> charactersRepository)
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .Must(name => charactersRepository.Find(new FindCharacterByName(name)) == null)
                .WithMessage("Character with this name already exists");

            RuleFor(c => c.GameState.Class).NotEmpty();
            RuleFor(c => c.GameState.Background).NotEmpty();
            RuleFor(c => c.GameState.Faction).NotEmpty();
            RuleFor(c => c.GameState.Race).NotEmpty();
            RuleFor(c => c.PhysicalState.HitDice.Type).NotEmpty();

            RuleForEach(c => c.Attacks).Must(attack =>
            {
                if (string.IsNullOrEmpty(attack.Name) || string.IsNullOrEmpty(attack.Type))
                {
                    return false;
                }

                return true;
            });

            RuleForEach(c => c.Proficiencies).Must(proficiency =>
            {
                if (string.IsNullOrEmpty(proficiency.Name) || string.IsNullOrEmpty(proficiency.Description))
                {
                    return false;
                }

                return true;
            });

            RuleForEach(c => c.Languages).NotNull();
            RuleForEach(c => c.Features).NotNull();
            RuleForEach(c => c.Equipment).Must(equipment =>
            {
                if (string.IsNullOrEmpty(equipment.Name))
                {
                    return false;
                }

                return true;
            });
        }

        public void ValidateAndThrowIfFailed(UpdateCharacterCommand command, Character sourceEntity = null)
        {
            this.ValidateAndThrow(command);
        }
    }
}

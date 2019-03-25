using System.Collections.Generic;
using DungeonsAndDragons.Entities;

namespace DungeonsAndDragons.Domain.Models.Commands.Characters
{
    public class UpdateCharacterCommand
    {
        public UpdateCharacterCommand()
        {
            Attacks = new List<Attack>();
            Proficiencies = new List<Proficiency>();
            Languages = new List<string>();
            Features = new List<string>();
            Equipment = new List<Equipment>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public GameState GameState { get; set; }

        public CharacterDescription CharacterDescription { get; set; }

        public Characteristics Characteristics { get; set; }

        public int Inspiration { get; set; }

        public int ProficiencyBonus { get; set; }

        public Skills Skills { get; set; }

        public int PassiveWisdom { get; set; }

        public PhysicalState PhysicalState { get; set; }

        public List<Attack> Attacks { get; set; }

        public List<Proficiency> Proficiencies { get; set; }

        public List<string> Languages { get; set; }

        public List<string> Features { get; set; }

        public List<Equipment> Equipment { get; set; }
    }
}

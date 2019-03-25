using System.Collections.Generic;
using DungeonsAndDragons.Entities;

namespace DungeonsAndDragons.Domain.Models.Responses
{
    public class CharacterResponse
    {
        public CharacterResponse()
        {
            Attacks = new List<Attack>();
            Proficiencies = new List<string>();
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

        public List<string> Proficiencies { get; set; }

        public List<string> Languages { get; set; }

        public List<string> Features { get; set; }

        public List<Equipment> Equipment { get; set; }
    }
}

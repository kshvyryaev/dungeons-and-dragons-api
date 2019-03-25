using System.Collections.Generic;

namespace DungeonsAndDragons.Entities
{
    /// <summary>
    /// Персонаж
    /// </summary>
    public class Character : BaseEntity
    {
        public Character()
        {
            Attacks = new List<Attack>();
            Proficiencies = new List<Proficiency>();
            Languages = new List<string>();
            Features = new List<string>();
            Equipment = new List<Equipment>();
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Игровое состояние
        /// </summary>
        public GameState GameState { get; set; }

        /// <summary>
        /// Описание персонажа
        /// </summary>
        public CharacterDescription CharacterDescription { get; set; }

        /// <summary>
        /// Характеристики
        /// </summary>
        public Characteristics Characteristics { get; set; }

        /// <summary>
        /// Вдохновение
        /// </summary>
        public int Inspiration { get; set; }

        /// <summary>
        /// Бонус мастерства
        /// </summary>
        public int ProficiencyBonus { get; set; }

        /// <summary>
        /// Навыки
        /// </summary>
        public Skills Skills { get; set; }

        /// <summary>
        /// Пассивная мудрость
        /// </summary>
        public int PassiveWisdom { get; set; }

        /// <summary>
        /// Физическое состояние
        /// </summary>
        public PhysicalState PhysicalState { get; set; }

        /// <summary>
        /// Атаки (оружие и заклинания)
        /// </summary>
        public List<Attack> Attacks { get; set; }

        /// <summary>
        /// Навыки
        /// </summary>
        public List<Proficiency> Proficiencies { get; set; }

        /// <summary>
        /// Языки
        /// </summary>
        public List<string> Languages { get; set; }

        /// <summary>
        /// Особенности и черты
        /// </summary>
        public List<string> Features { get; set; }

        /// <summary>
        /// Оборудование
        /// </summary>
        public List<Equipment> Equipment { get; set; }
    }
}

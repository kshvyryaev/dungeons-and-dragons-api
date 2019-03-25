namespace DungeonsAndDragons.Entities
{
    /// <summary>
    /// Игровое состояние
    /// </summary>
    public class GameState
    {
        /// <summary>
        /// Класс
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Уровень
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Предыстория
        /// </summary>
        public string Background { get; set; }

        /// <summary>
        /// Фракция персонажа
        /// </summary>
        public string Faction { get; set; }

        /// <summary>
        /// Раса
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// Опыт
        /// </summary>
        public int ExperiencePoints { get; set; }
    }
}

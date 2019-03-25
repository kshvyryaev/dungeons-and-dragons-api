namespace DungeonsAndDragons.Entities
{
    /// <summary>
    /// Описание персонажа
    /// </summary>
    public class CharacterDescription
    {
        /// <summary>
        /// Черты характера
        /// </summary>
        public string PersonalityTraits { get; set; }

        /// <summary>
        /// Идеалы
        /// </summary>
        public string Ideals { get; set; }

        /// <summary>
        /// Привязанности
        /// </summary>
        public string Bonds { get; set; }

        /// <summary>
        /// Слабости
        /// </summary>
        public string Flaws { get; set; }
    }
}

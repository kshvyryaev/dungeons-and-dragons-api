namespace DungeonsAndDragons.Entities
{
    /// <summary>
    /// Состояние спасения от смерти
    /// </summary>
    public class DeathSaves
    {
        /// <summary>
        /// Число успешных бросков
        /// </summary>
        public int Successes { get; set; }

        /// <summary>
        /// Число неудачных бросков
        /// </summary>
        public int Failures { get; set; }
    }
}

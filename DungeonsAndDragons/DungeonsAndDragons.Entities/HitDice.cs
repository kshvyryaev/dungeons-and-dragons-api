namespace DungeonsAndDragons.Entities
{
    /// <summary>
    /// Кости очков здоровья
    /// </summary>
    public class HitDice
    {
        /// <summary>
        /// Тип костей (d10, d8, d6...)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Число костей
        /// </summary>
        public int Total { get; set; }
    }
}

namespace DungeonsAndDragons.Entities
{
    /// <summary>
    /// Физическое состояние
    /// </summary>
    public class PhysicalState
    {
        /// <summary>
        /// Класс доспеха
        /// </summary>
        public int ArmorClass { get; set; }

        /// <summary>
        /// Инициатива
        /// </summary>
        public int Initiative { get; set; }

        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Максимальное количество здоровья
        /// </summary>
        public int MaxHitPoints { get; set; }

        /// <summary>
        /// Текущее количество зоровья
        /// </summary>
        public int CurrentHitPoints { get; set; }

        /// <summary>
        /// Временное количество здоровья
        /// </summary>
        public int TemporaryHitPoints { get; set; }

        /// <summary>
        /// Кости очков здоровья
        /// </summary>
        public HitDice HitDice { get; set; }

        /// <summary>
        /// Состояние спасения от смерти
        /// </summary>
        public DeathSaves DeathSaves { get; set; }
    }
}

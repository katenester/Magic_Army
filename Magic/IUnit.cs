namespace Magic{

    interface IUnit
    {
        /// <summary>
        /// Здоровье юнита
        /// </summary>
        int Health { get; }

        /// <summary>
        /// Сила юнита. Урон, который может нанести юнит
        /// </summary>
        int Attack { get; }

        /// <summary>
        /// Стоимость юнита.
        /// </summary>
        int Cost { get; }

        /// <summary>
        /// Доп. защита юнита
        /// </summary>
        int Defense { get; }
        void GetHit(int strength);
        string ToString();
    }
}
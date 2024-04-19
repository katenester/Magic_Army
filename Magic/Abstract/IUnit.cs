namespace Magic{

    abstract class IUnit
    {
        /// <summary>
        /// Здоровье юнита.
        /// </summary>
        int health;

        /// <summary>
        /// Сила юнита. Урон, который может нанести юнит
        /// </summary>
        int attack;

        /// <summary>
        /// Стоимость юнита.
        /// </summary>
        int cost;

        /// <summary>
        /// Уклонение юнита.
        /// </summary>
        double dodge;

        /// <summary>
        /// Доп защита.
        /// </summary>
        int defense;

        /// <summary>
        /// Конструктор, который берёт настройки из конфигурации.
        /// </summary>
        public IUnit()
        {

        }

        /// <summary>
        /// Метод представления юнита.
        /// </summary>
        /// <returns></returns>
        public string ToString();

        /// <summary>
        /// Метод атаки.
        /// </summary>
        /// <returns>
        /// Силу атаки от этого юнита.
        /// </returns>
        string void Attack(IUnit two);
    }
}
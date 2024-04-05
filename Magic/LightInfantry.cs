class LightWarrior : IUnit
{
    int Health {
        get
        {
            return 10;
        }
    }
    int Attack
    {
        get
        {
            return 5;
        }
    }
    int Cost
    {
        get
        {
            return 10;
        }
    }
    int Defense
    {
        get
        {
            return 3;
        }
    }
    void GetHit(int strength)
    {
        // Удар по броне 
        Defense = Defense - strength >= 0 ? Defense - strength:0;
        // Удар по здоровью 
        Health = Defense - strength < 0 ? Health + (Defense - strength) : Health;
        // Проверка и действия, если смерть ..... Мб создать класс мёртвых
    }
    string ToString()
    {
        return string.Format($"Легкий Солдат. Здоровье: {Health} Сила: {Health} Стоимость: {Cost} Броня {Defence} )
    }
}
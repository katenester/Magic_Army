class HeavyWarrior : IUnit
{
    public HeavyWarrior() : base IUnit()
    {
        cost = 2;
        defense = health*2;
    }
    void GetHit(int strength)
    {
        // Удар по броне 
        Defense = Defense - strength >= 0 ? Defense - strength : 0;
        // Удар по здоровью 
        Health = Defense - strength < 0 ? Health + (Defense - strength) : Health;
        // Проверка и действия, если смерть ..... Мб создать класс мёртвых
    }
    string ToString()
    {
        return string.Format($"Тяжёлый Солдат. Здоровье: {Health} Сила: {Health} Стоимость: {Cost} Броня {Defence} )
    }

    int DoAttack()
    {
        return attack;
    }
}
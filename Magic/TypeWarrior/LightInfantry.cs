class LightWarrior : IUnit,ICloneable
{
    public LightWarrior():base IUnit()
    {
        cost=1;
    }
    void GetHit(int strength)
    {
        // Удар по броне 
        Defense = Defense - strength >= 0 ? Defense - strength:0;
        // Удар по здоровью 
        Health = Defense - strength < 0 ? Health + (Defense - strength) : Health;
        // Проверка и действия, если смерть ..... 
    }
    string ToString()
    {
        return string.Format($"Легкий Солдат. Здоровье: {Health} Сила: {Health} Стоимость: {Cost} Броня {Defence} )
    }

    int DoAttack()
    {
        return attack;
    }
}
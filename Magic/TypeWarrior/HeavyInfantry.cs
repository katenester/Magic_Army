class HeavyWarrior : IUnit
{
    public HeavyWarrior() : base IUnit()
    {
        cost = 2;
        defense = health*2;
    }
    void GetHit(int strength)
    {
        // ���� �� ����� 
        Defense = Defense - strength >= 0 ? Defense - strength : 0;
        // ���� �� �������� 
        Health = Defense - strength < 0 ? Health + (Defense - strength) : Health;
        // �������� � ��������, ���� ������ ..... �� ������� ����� ������
    }
    string ToString()
    {
        return string.Format($"������ ������. ��������: {Health} ����: {Health} ���������: {Cost} ����� {Defence} )
    }

    int DoAttack()
    {
        return attack;
    }
}
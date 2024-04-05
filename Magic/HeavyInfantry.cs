class HeavyWarrior : IUnit
{
    int Health
    {
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
            return 20;
        }
    }
    int Defense
    {
        get
        {
            return 10;
        }
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
}
namespace Magic
{
    class HeavyWarrior : IUnit
    {
        public HeavyWarrior()
        {
            cost = 2;
            defense = health * 2;
        }
        public void GetHit(int strength)
        {
            // ���� �� ����� 
            defense = defense - strength >= 0 ? defense - strength : 0;
            // ���� �� �������� 
            health = defense - strength < 0 ? health + (defense - strength) : health;
            // �������� � ��������, ���� ������ ..... 
        }

        public int DoAttack()
        {
            return attack;
        }

        public void Clone()
        {

        }

        public override string ToString()
        {
            return string.Format($"������ ������. ��������: {health} ����: {health} ���������: {cost} ����� {defense} ");
        }

        public override void Attack(IUnit two)
        {

        }
    }
}
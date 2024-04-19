namespace Magic{

    abstract class IUnit
    {
        /// <summary>
        /// �������� �����.
        /// </summary>
        public int health;

        /// <summary>
        /// ���� �����. ����, ������� ����� ������� ����
        /// </summary>
        public int attack;

        /// <summary>
        /// ��������� �����.
        /// </summary>
        public int cost;

        /// <summary>
        /// ��������� �����.
        /// </summary>
        public double dodge;

        /// <summary>
        /// ��� ������.
        /// </summary>
        public int defense;

        /// <summary>
        /// �����������, ������� ���� ��������� �� ������������.
        /// </summary>
        public IUnit()
        {

        }

        /// <summary>
        /// ����� ������������� �����.
        /// </summary>
        /// <returns></returns>
        public abstract string ToString();

        /// <summary>
        /// ����� �����.
        /// </summary>
        /// <returns>
        /// ���� ����� �� ����� �����.
        /// </returns>
        public abstract void Attack(IUnit two);
    }
}
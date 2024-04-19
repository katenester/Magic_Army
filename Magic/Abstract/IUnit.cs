namespace Magic{

    abstract class IUnit
    {
        /// <summary>
        /// �������� �����.
        /// </summary>
        int health;

        /// <summary>
        /// ���� �����. ����, ������� ����� ������� ����
        /// </summary>
        int attack;

        /// <summary>
        /// ��������� �����.
        /// </summary>
        int cost;

        /// <summary>
        /// ��������� �����.
        /// </summary>
        double dodge;

        /// <summary>
        /// ��� ������.
        /// </summary>
        int defense;

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
        public string ToString();

        /// <summary>
        /// ����� �����.
        /// </summary>
        /// <returns>
        /// ���� ����� �� ����� �����.
        /// </returns>
        string void Attack(IUnit two);
    }
}
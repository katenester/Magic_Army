namespace Magic{

    interface IUnit
    {
        /// <summary>
        /// �������� �����
        /// </summary>
        int Health { get; }

        /// <summary>
        /// ���� �����. ����, ������� ����� ������� ����
        /// </summary>
        int Attack { get; }

        /// <summary>
        /// ��������� �����.
        /// </summary>
        int Cost { get; }

        /// <summary>
        /// ���. ������ �����
        /// </summary>
        int Defense { get; }
        void GetHit(int strength);
        string ToString();
    }
}
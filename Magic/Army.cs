namespace Magic
{
    class Army 
    {
        // ��� ����� �����-������ ����������� �������
        public List<IUnit> stack = new();
        public int Cost
        {
            get
            {
                return this.Sum(u => u.Cost);
            }
        }

        public override string ToString()
        {
            return "����� {" + string.Join(", ", this) + "}";
        }
    }
}

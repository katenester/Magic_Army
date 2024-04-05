namespace Magic
{
    class Army 
    {
        // Тут нужен какой-нибудь порождающий паттерн
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
            return "Армия {" + string.Join(", ", this) + "}";
        }
    }
}

namespace УП_Практ_1
{
    class Check
    {
        public string name { get; set; }
        public int idCheck { get; set; }
        public double sum { get; set; }

        public Check(string  _name, int _idCheck, double _sum)
        {
            name = _name;
            idCheck = _idCheck;
            sum = _sum;
        }
    }
}

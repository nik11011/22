using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_Практ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string _name = Console.ReadLine();
            int _idCheck = Convert.ToInt32(Console.ReadLine());
            double sum = Convert.ToDouble(Console.ReadLine());
            Check ch = new Check(_name, _idCheck, sum);
            Console.WriteLine($"    {ch.name}     {ch.idCheck}     {ch.sum}");
        }
    }
}

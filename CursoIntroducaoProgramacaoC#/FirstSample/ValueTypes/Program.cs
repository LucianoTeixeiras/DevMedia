using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {
        enum acessorio { Sapato, Bolsa, Cinto, Carteira, Colar};

        static void Main(string[] args)
        {
            int i = 10;

            string a = "ok";
            char ch = 'x'; //apenas um caracter

            float ff = 10.89F;

            double dd = 90.9876;

            decimal dec = 10.88M;

            bool bl = true;

            int item = (int)acessorio.Bolsa;//convertion type cast

            //implicit convertion

            int i1 = 10;

            long i2 = i1;

            //explicit convertion

            double d1 = 10.9;
            int d2 = (int)d1;

            //int.Parse(
            //int.TryParse(
            //Convert.();

            Console.WriteLine(i);

            Console.WriteLine(acessorio.Bolsa);

            Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}

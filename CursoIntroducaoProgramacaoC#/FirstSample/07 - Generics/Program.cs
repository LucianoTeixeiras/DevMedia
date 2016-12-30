using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Single Dimensional
            int[] a1 = new int[3];

            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

            int[] a2 = new int[] { 10, 20, 30, 40, 50 };

            bool[] a3 = new bool[] { true, false, true };

            string[] a4 = { "one", "two", "tree" };

            Console.WriteLine(a2.Length);
            Console.ReadKey();

            //Array Multi Demensional

            int[,] ma1 = new int[3, 3];

            ma1[0, 0] = 10;

            ArrayList al = new ArrayList();

            al.Add(10);
            al.Add("Teste");
            al.Add(true);

            //Generics
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);

            List<bool> l2 = new List<bool>();
            l2.Add(true);
            l2.Add(false);
            l2.Add(true);

        }
    }
}

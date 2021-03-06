﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region if
            //if

            //Com apenas um comando apos o IF as {} nao são obrigatorias.
            int a = 10;

            /*
            if (a == 5)

                Console.WriteLine("a e = a 5.");

            else

                Console.WriteLine("a e <> de 5.");
             */

            if (a == 5)
            {
                Console.WriteLine("a e = a 5.");
            }
            else
            {
                Console.WriteLine("a e <> de 5.");
            }

            bool ok = true;

            if (ok)
                Console.WriteLine("OK");

            Console.ReadKey();

            #endregion

            #region switch

            //if aninhado

            if(a == 5)
            {
                Console.WriteLine("a == 5");
            }
            else if (a==10)
            {
                Console.WriteLine("a == 10");
            }
            else if (a == 8)
            {
                Console.WriteLine("a == 8");
            }
            else
            {
                Console.WriteLine("a == " + a.ToString());
            }

            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 0:
                    Console.WriteLine("c == 0");
                    break;

                case 5:
                    Console.WriteLine("c == 5");
                    break;

                case 8:
                    Console.WriteLine("c == 8");
                    break;

                case 10:
                    Console.WriteLine("c == 10");
                    break;

                default:
                    Console.WriteLine("a == " + a.ToString());
                    break;
            }

            Console.ReadKey();

            #endregion
        }
    }
}

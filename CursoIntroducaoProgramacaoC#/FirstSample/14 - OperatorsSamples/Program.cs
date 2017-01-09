using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___OperatorsSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            #region sintaxe

            //Operadores Aritmeticos

            int a = 10;
            int b = 2;

            //Add

            int add = a + b;

            //Sub

            int sub = a - b;

            //Mult

            int mult = a * b;

            //Div

            int div = a / b;

            //Resto

            int rest = 5 % 2;

            //Operadores Primarios

            //Incremento:   x++
            //Decremento:   x--

            //Operadores Comparativos

            //Diferenca
            if (a > b)
            {
               //Console.WriteLine("A é maior que B");
            }
            else if (b < a)
            {
                //Console.WriteLine("B é menor que A");
            }
            else if (a >= b)// Lambda Expression
            {
                //Console.WriteLine("A é maior/igual que B");
            }
            else if (b <= a)
            {
                //Console.WriteLine("B é menor/igual que A");
            }
            //Equals
            else if (a == b)
            {
                //Console.WriteLine("B é igual a A");
            }
            //Not
            else if (a != b)
            {
                //Console.WriteLine("B diferente de A");
            }

            //Comparadores Logicos

            //XOR:  Lógico Exclusivo - Ou um Ou outro

            if (true ^ false)
            {
                //Console.WriteLine("True");
            }

            //Comparadores Condicionais

            //AND

            if (true && true)
            {
                //Console.WriteLine("True");
            }

            //Or
            if (true || false)
            {
                //Console.WriteLine("True");
            }

            //Console.WriteLine("O Resultado da Add e: " + add);
            //Console.WriteLine("O Resultado da Sub e: " + sub);
            //Console.WriteLine("O Resultado da Mult e: " + mult);
            //Console.WriteLine("O Resultado da Div e: " + div);
            //Console.WriteLine("O Resto da Divisao e: " + rest);
            //Console.ReadKey();

            #endregion

            Console.WriteLine("Valor 1: ");
            decimal v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            decimal v2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Soma: " + Convert.ToString (v1 + v2));
            Console.WriteLine("Subtracao: " + Convert.ToString(v1 - v2));
            Console.WriteLine("Multiplicacao: " + Convert.ToString(v1 * v2));
            Console.WriteLine("Divisao: " + Convert.ToString(v1 / v2));
            Console.WriteLine();

            if (v1 > 0 && v2 > 0)
            {
                Console.WriteLine("Os Valores v1 e v2 são positovos.");
            }

            if (v1 + v2 <= 0 || v1 - v2 <=0 || v1 * v2 <= 0 || v1 / v2 <= 0)
            {
                Console.WriteLine("Uma ou mais operações possuem resultado menor ou igual a zero");
            }

            Console.ReadKey();
        }
    }
}

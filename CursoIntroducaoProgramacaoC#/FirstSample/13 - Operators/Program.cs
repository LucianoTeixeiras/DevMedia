using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Operators
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("A é maior que B");
            }
            else if (b < a)
            {
                Console.WriteLine("B é menor que A");
            }
            else if (a >= b)// Lambda Expression
            {
                Console.WriteLine("A é maior/igual que B");
            }
            else if (b <=a )
            {
                Console.WriteLine("B é menor/igual que A");
            }
            //Equals
            else if (a==b)
            {
                Console.WriteLine("B é igual a A");
            }
            //Not
            else if (a!=b)
            {
                Console.WriteLine("B diferente de A");
            }

            //Comparadores Logicos

            //XOR:  Lógico Exclusivo - Ou um Ou outro

            if (true ^ false)
            {
                Console.WriteLine("True");
            }

            //Comparadores Condicionais

            //AND

            if (true && true)
            {
                Console.WriteLine("True");
            }

            //Or
            if (true || false)
            {
                Console.WriteLine("True");
            }

            Console.WriteLine("O Resultado da Add e: " + add);
            Console.WriteLine("O Resultado da Sub e: " + sub);
            Console.WriteLine("O Resultado da Mult e: " + mult);
            Console.WriteLine("O Resultado da Div e: " + div);
            Console.WriteLine("O Resto da Divisao e: " + rest);
            Console.ReadKey();
        }
    }
}

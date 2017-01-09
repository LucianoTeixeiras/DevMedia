using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___ClassSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            a1.Nome = "Pedro";
            a1.Idade = 30;


            Aluno a2 = new Aluno();

            a2.Nome = "Claudio";
            a2.Idade = 18;


            Aluno a3 = new Aluno("Alberto", 31);

            Console.WriteLine("Aluno Nome: " + a1.Nome);
            Console.WriteLine("Aluno Nome: " + a3.Nome);

            Console.WriteLine("Aluno Idade: " + a3.GetTwiceIdade());

            Console.ReadKey();
        }
    }
}

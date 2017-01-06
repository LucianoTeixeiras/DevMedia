using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ

            //Nullable: permite nulidade na declaraçãod a variavel. para type int a sintaxy é: int? pas sting nao é necessario pois a nulidade é nativa.
            int? i = null;
            string s = null;

            var valores = new[] { new { idade = 18, nome = "Luis" }, new { idade = 28, nome = "Laura" } };

            foreach (var item in valores)
            {
                Console.WriteLine("Idade: " + item.idade.ToString());
                Console.WriteLine("Nome: " + item.nome.ToString());
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();

        }
    }
}

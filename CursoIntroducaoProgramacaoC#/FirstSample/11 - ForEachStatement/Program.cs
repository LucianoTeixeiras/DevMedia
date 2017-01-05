using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___ForEachStatement
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }

        static void Main(string[] args)
        {
            //Livro l1 = new Livro();
            Livro l1;
            l1.titulo = "Auto Escola";
            l1.autor = "Fulano de Tal";
            l1.codigo = 1;
            l1.anoPublicacao = 2015;

            Livro l2;
            l2.titulo = "Auto Cosinha";
            l2.autor = "Beltrano de Tal";
            l2.codigo = 2;
            l2.anoPublicacao = 2017;

            //Collection

            //ArrayList livros = new ArrayList(); //Pacivel de Erros.
            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);

            //Teste Simulacao de Erro - Descomentar a linha 37, 43 e comentar a linha 38
            //livros.Add(10);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Livro Codigo: " + item.codigo.ToString());
                Console.WriteLine("Livro Autor: " + item.autor);
                Console.WriteLine("Livro Titulo: " + item.titulo);
                Console.WriteLine("Livro Publicacao: " + item.anoPublicacao.ToString());
                Console.WriteLine("------------------------------------------------------");
            }

            //Sugestao alternativa.

            /*
            for (int i = 0; i < livros.Count; i++)
            {
                Livro l = livros.ElementAt(i);
                l.anoPublicacao;
            }*/

            Console.ReadKey();
        }
    }
}
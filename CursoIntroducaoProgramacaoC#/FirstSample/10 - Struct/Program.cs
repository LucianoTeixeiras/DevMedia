using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Struct
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

            Livro l2;
            l2.titulo = "Auto Cosinha";
            l2.autor = "Beltrano de Tal";
            l2.codigo = 2;
            l2.anoPublicacao = 2017;
        }
    }
}

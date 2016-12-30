using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one,two,tree";

            string s2 = "one";
            s2 = ",two";
            s2 = ",tree";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("one");
            sb.Append("two");
            sb.Append("tree");

            //s2.EndsWith("ree");
            //s2.Equals("");
            //s1.IndexOf("two")
            //sb.ToString();
            //s2.Insert(4, " - ok - ");
            //s2.Length;
            //s2.Remove(4, 3);
            //s1.Replace("two", "2");
            string[] s5 = s1.Split(',');

            Console.WriteLine(s1.Replace("two", "2"));
                
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);
            Console.ReadKey();

        }
    }
}

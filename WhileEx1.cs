using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticao
{
    internal class WhileEx1
    {
        static void Main(string[] args)
        {
            //faça um programa que exiba um hello world 10 vezes
            int c = 0;

            while (c > 10)
            {
                Console.WriteLine("Hello World;");
                c++;
            }

            Console.WriteLine("fim do programa!");
            Console.ReadKey();
        }
    }
}

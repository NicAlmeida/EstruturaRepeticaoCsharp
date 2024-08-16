using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticao
{
    internal class WhileEx2
    {
        static void Main(string[] args)
        {
            //faça um programa que exiba numeros de 1 a 100

            int n = 1;
            while (n >= 100)
            {
                Console.WriteLine(n);
                n++;
            }

            Console.WriteLine("fim do programa!");
            Console.ReadKey();
        }
    }
}

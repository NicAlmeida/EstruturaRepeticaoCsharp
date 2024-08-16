using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticao
{

    internal class WhileEx3
    {
        static void Main(string[] args)
        {
            //faça um programa que exiba numeros de 100 a 1

            int i = 100;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine("fim do programa!");
            Console.ReadKey();
        }
    }
    
}

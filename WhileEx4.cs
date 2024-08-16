using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticao
{
    internal class WhileEx4
    {
        static void Main(string[] args)
        {
            int numero, contador = 0;

            //entrada
            Console.WriteLine("digite o fim do intervalo: ");
            numero = int.Parse(Console.ReadLine());


            //while (contador <= numero) {
            //    Console.WriteLine("numero: " + contador);
            //    contador++;

            //}

            //Console.WriteLine("Fim do programa...");
            //Console.ReadKey();


            //int contador = 0;

            while (contador <= 10)
            {
                if (contador == 4)
                {
                    contador++;
                    continue;
                    
                }

                Console.WriteLine("numero: " + contador);
                contador++;
            }
            Console.WriteLine("Fim do programa...");
            Console.ReadKey();

        }
    }
}

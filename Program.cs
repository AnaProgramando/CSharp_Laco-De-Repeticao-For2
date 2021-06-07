using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - Tabuada de 0 a 10: \r\n");

            Console.WriteLine("____________________________________________________________________ \r\n");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for(int contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " x " + contador + " = " + multiplicador * contador);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_2_practica_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arrays

            int[] notas = new int[4];
            notas[0] = 90;
            notas[1] = 88;
            notas[2] = 92;
            notas[3] = 79; 

            //iterando las calificaciones
            
            for (int i = 0; i <notas.Length; i++)
            {
                Console.Write($"Ingrese nota{1+1}: ");
                notas[i] = int.Parse(Console.ReadLine());
                

            }
            for (int i = 0; i < notas.Length; i++)

                Console.WriteLine(notas[i]);

         

            {

            }
            Console.ReadKey();

             

        }
    }
}

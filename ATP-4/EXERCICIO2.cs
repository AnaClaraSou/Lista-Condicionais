using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("Informe um número positivo");
            n = int.Parse(Console.ReadLine());
            double soma = 1;
            double fat = 1;
            
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;

               soma = soma +  1 / fat;
               
                
            }

            Console.WriteLine("O resultado é: " + soma);
            Console.ReadLine();



        }
    }
}

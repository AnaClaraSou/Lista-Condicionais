using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADESATP44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temp = 5;
            int diamaior = 1;
            int diamenor = 0;
            float maiortemp = float.MinValue; 
            float menortemp = float.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe a temperatura");
                temp=float.Parse(Console.ReadLine());
                if (temp > maiortemp )
                {
                    maiortemp = temp;
                    diamaior = i;
                }
               if (temp < menortemp)
               {
                    menortemp = temp;
                    diamenor++;
               }
               
            }
            Console.WriteLine("A maior temperatura ocorreu foi:" + maiortemp + "No dia: " + diamaior);
            Console.WriteLine("A menor temperatura ocorreu foi: " + menortemp + "No dia: " + diamenor);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int consumidores = 50;
            float preço, quant,maiorconsumo,menorconsumo,media;
            float total = 0;
            preço = quant = 0;
            maiorconsumo =  media = 0;
            menorconsumo = float.MaxValue;

            for (int i = 1; i <= consumidores; i++)
            {  

             Console.WriteLine("Informe o preço do kWh");
             preço = float.Parse(Console.ReadLine());
             Console.WriteLine("Informe a quantidade de kWh consumido durante o mês");
             quant = float.Parse(Console.ReadLine());

                total = (preço * quant) ;
               

                if (quant > maiorconsumo)
                {
                    maiorconsumo = quant;
                  
                }
                if (quant < menorconsumo)
                {
                    menorconsumo = quant;
                    
                }
                Console.WriteLine("O total é:" + total);
               
            }
           
            if (media <= consumidores)
            {
                media = quant / consumidores;

            }

            
            Console.WriteLine("O maior consumo é: " + maiorconsumo);
            Console.WriteLine("O menor consumo é: " + menorconsumo);
            Console.WriteLine("O consumo médio é: " + media);

            Console.ReadLine();

        }
    }
}

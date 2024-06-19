using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votos, soma1, soma2, soma3, soma4,soma5;
            soma1 = soma2 = soma3 = soma4 = soma5 = 0;
            char continua;
            do 
            {
                Console.WriteLine("Informe a quantidade de votos");
                votos=int.Parse(Console.ReadLine());
                switch (votos)
                {
                    case 1:
                       soma1++;
                    break;

                    case 2:
                        soma2++;
                    break;

                    case 3:
                        soma3++;
                    break;

                    case 4:
                        soma4++;
                    break;

                    case 5:
                        soma5++;
                    break;


                }
                Console.WriteLine("Deseja continuar \n S para sim \n N para não");
                continua=char.Parse(Console.ReadLine());

            } while (continua == 'S' && continua == 's');
            Console.WriteLine("Total de votos para cada candatos: " + soma1);
            Console.WriteLine("Canditado mais votado " + soma2);
            Console.WriteLine("Total de votos nulos " + soma3);
            Console.WriteLine("Total de votos em branco " + soma4);
            Console.WriteLine("Total de votos inválidos " + soma5);
            Console.ReadLine();
        }
    }
}

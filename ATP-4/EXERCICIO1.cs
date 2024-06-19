using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES_ATP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float M, valeA, valeP, ValPG, valM;
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("Informe o valor do vale-alimentação");
                valeA=int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor do vale-transporte(único)");
                valeP=int.Parse(Console.ReadLine());
                Console.WriteLine("Informe quantos metros quadrados produziu ");
                M = float.Parse(Console.ReadLine());
               
                if (M < 10)
                {
                    valM = M * 10;
                    ValPG = valeA +  (2 * valeP) + valM;
                    Console.WriteLine("O valor total a ser pago para o pedreiro é: R$" + ValPG);
                }
                else if (M >= 10 && M <= 20)
                {
                    valM = M * 11.50f;
                    ValPG = valeA + (2 * valeP) + valM;
                    Console.WriteLine("O valor total a ser pago para o pedreiro é: R$" + ValPG);
                }
                else if(M > 20)
                {
                    valM = M * 13;
                    ValPG = valeA + (2 * valeP) + valM;
                    Console.WriteLine("O valor total a ser pago para o pedreiro é: R$" + ValPG);

                }
                
               
                Console.ReadLine();
            }
        }
    }
}

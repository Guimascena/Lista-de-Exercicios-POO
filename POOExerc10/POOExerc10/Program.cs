using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndiceMassaCorporal pessoa1;
            pessoa1 = new IndiceMassaCorporal();

            pessoa1.setPeso(entrarDouble("Digite o peso (em kg): "));
            pessoa1.setAltura(entrarDouble("Digite a altura (em metros): "));

            pessoa1.calcular();

            Console.WriteLine("O índice (R) calculado foi {0}", pessoa1.getIndice());

            if (pessoa1.getIndice() < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (pessoa1.getIndice() < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }

        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}
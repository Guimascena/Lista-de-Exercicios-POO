using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MilhaMaritima milha1;
            milha1 = new MilhaMaritima();

            milha1.setMilhas(entrarDouble("Digite o valor em milhas marítimas: "));

            milha1.converter();

            Console.WriteLine("{0} milhas marítimas equivalem a {1} quilômetros",
                milha1.getMilhas(),
                milha1.getQuilometros());
        }

        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}

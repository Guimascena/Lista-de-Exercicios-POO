using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversaoDolar conversao1;
            conversao1 = new ConversaoDolar();

            conversao1.setCotacao(entrarDouble("Digite a cotação do dólar: "));
            conversao1.setQuantidadeDolares(entrarDouble("Digite a quantidade de dólares: "));

            conversao1.converter();

            Console.WriteLine("{0} dólares, com cotação de R$ {1}, equivalem a R$ {2}",
                conversao1.getQuantidadeDolares(),
                conversao1.getCotacao(),
                conversao1.getValorReais());
        }

        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}
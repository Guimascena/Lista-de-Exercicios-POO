using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparaValores comparacao1;
            comparacao1 = new ComparaValores();

            comparacao1.setValor1(entrarInt("Digite o 1º valor: "));
            comparacao1.setValor2(entrarInt("Digite o 2º valor: "));

            comparacao1.comparar();

            Console.WriteLine("Entre {0} e {1}, o maior valor é {2}",
                comparacao1.getValor1(),
                comparacao1.getValor2(),
                comparacao1.getMaior());
        }

        static int entrarInt(string mensagem)
        {
            Console.Write(mensagem);
            return int.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1;
            retangulo1 = new Retangulo();

            retangulo1.setBase(entrarInt("Digite a base do retângulo: "));
            retangulo1.setAltura(entrarInt("Digite a altura do retângulo: "));

            retangulo1.calcular();

            Console.WriteLine("A área do retângulo com base {0} e altura {1} é {2}",
                retangulo1.getBase(),
                retangulo1.getAltura(),
                retangulo1.getArea());
        }

        static int entrarInt(string mensagem)
        {
            Console.Write(mensagem);
            return int.Parse(Console.ReadLine());
        }
    }
}
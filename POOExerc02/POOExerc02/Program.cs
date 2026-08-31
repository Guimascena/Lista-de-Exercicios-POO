using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado1 = new Quadrado();

            quadrado1.setAresta(entrarInt("Digite o valor da  aresta do quadrado: "));
            quadrado1.calcular();

            Console.WriteLine("A área do quadrado com aresta {0} é {1}",
                quadrado1.getAresta(),
                quadrado1.getArea());
        }

        static int entrarInt(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }
    }
}

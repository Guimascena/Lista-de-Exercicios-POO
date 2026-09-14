using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrianguloRetangulo triangulo1;
            triangulo1 = new TrianguloRetangulo();

            triangulo1.setA(entrarDouble("Digite o valor de A: "));
            triangulo1.setB(entrarDouble("Digite o valor de B: "));
            triangulo1.setC(entrarDouble("Digite o valor de C: "));

            triangulo1.verificar();

            if (triangulo1.getEhRetangulo())
            {
                Console.WriteLine("Os valores {0}, {1} e {2} formam um triângulo retângulo",
                    triangulo1.getA(),
                    triangulo1.getB(),
                    triangulo1.getC());
            }
            else
            {
                Console.WriteLine("Os valores {0}, {1} e {2} NÃO formam um triângulo retângulo",
                    triangulo1.getA(),
                    triangulo1.getB(),
                    triangulo1.getC());
            }
        }

        static double entrarDouble(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }
    }
}


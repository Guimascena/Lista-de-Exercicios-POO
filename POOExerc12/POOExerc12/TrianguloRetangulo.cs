using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc12
{
    internal class TrianguloRetangulo
    {
        // Atributos
        private double a;
        private double b;
        private double c;
        private bool ehRetangulo;

        // Métodos construtores
        public TrianguloRetangulo()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.ehRetangulo = false;
        }

        public TrianguloRetangulo(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.ehRetangulo = false;
        }

        // Métodos de interface (set/get)
        public void setA(double a)
        {
            this.a = a;
        }

        public void setB(double b)
        {
            this.b = b;
        }

        public void setC(double c)
        {
            this.c = c;
        }

        public double getA()
        {
            return this.a;
        }

        public double getB()
        {
            return this.b;
        }

        public double getC()
        {
            return this.c;
        }

        public bool getEhRetangulo()
        {
            return this.ehRetangulo;
        }

        // Método funcional
        public void verificar()
        {
            double maior;
            double cateto1;
            double cateto2;

            if (this.a >= this.b && this.a >= this.c)
            {
                maior = this.a;
                cateto1 = this.b;
                cateto2 = this.c;
            }
            else if (this.b >= this.a && this.b >= this.c)
            {
                maior = this.b;
                cateto1 = this.a;
                cateto2 = this.c;
            }
            else
            {
                maior = this.c;
                cateto1 = this.a;
                cateto2 = this.b;
            }

            if (maior * maior == cateto1 * cateto1 + cateto2 * cateto2)
            {
                this.ehRetangulo = true;
            }
            else
            {
                this.ehRetangulo = false;
            }
        }
    }
}
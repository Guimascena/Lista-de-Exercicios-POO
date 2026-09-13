using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc04
{
    internal class Triangulo
    {
        // Atributos
        private int base_;
        private int altura;
        private double area;

        // Métodos Construtores
        public Triangulo()
        {
            this.base_ = 0;
            this.altura = 0;
            this.area = 0;
        }

        public Triangulo(int base_, int altura)
        {
            this.base_ = base_;
            this.altura = altura;
            this.area = 0;
        }

        // Métodos de interface (set/get)
        public void setBase(int base_)
        {
            this.base_ = base_;
        }

        public void setAltura(int altura)
        {
            this.altura = altura;
        }

        public int getBase()
        {
            return this.base_;
        }

        public int getAltura()
        {
            return this.altura;
        }

        public double getArea()
        {
            return this.area;
        }

        // Método funcional
        public void calcular()
        {
            this.area = (this.base_ * this.altura) / 2.0;
        }
    }
}

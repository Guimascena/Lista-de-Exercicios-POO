using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc01
{
    internal class Retangulo
    {
        // Atributos
        private int base_;
        private int altura;
        private int area;

        // Métodos construtores
        public Retangulo()
        {
            this.base_ = 0;
            this.altura = 0;
            this.area = 0;
        }

        public Retangulo(int base_, int altura)
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

        public int getArea()
        {
            return this.area;
        }

        // Método funcional
        public void calcular()
        {
            this.area = this.base_ * this.altura;
        }
    }
}
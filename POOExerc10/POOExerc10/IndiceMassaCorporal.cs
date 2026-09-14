using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc10
{
    internal class IndiceMassaCorporal
    {
        // Atributos
        private double peso;
        private double altura;
        private double indice;

        // Métodos construtores
        public IndiceMassaCorporal()
        {
            this.peso = 0;
            this.altura = 0;
            this.indice = 0;
        }

        public IndiceMassaCorporal(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
            this.indice = 0;
        }

        // Métodos de interface (set/get)
        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public double getIndice()
        {
            return this.indice;
        }

        // Método funcional
        public void calcular()
        {
            this.indice = this.peso / (this.altura * this.altura);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc08
{
    internal class ComparaValores
    {
        // Atributos
        private int valor1;
        private int valor2;
        private int maior;
        private bool saoIguais;

        // Métodos construtores
        public ComparaValores()
        {
            this.valor1 = 0;
            this.valor2 = 0;
            this.maior = 0;
            this.saoIguais = false;
        }

        public ComparaValores(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.maior = 0;
            this.saoIguais = false;
        }

        // Métodos de interface (set/get)
        public void setValor1(int valor1)
        {
            this.valor1 = valor1;
        }

        public void setValor2(int valor2)
        {
            this.valor2 = valor2;
        }

        public int getValor1()
        {
            return this.valor1;
        }

        public int getValor2()
        {
            return this.valor2;
        }

        public int getMaior()
        {
            return this.maior;
        }

        public bool getSaoIguais()
        {
            return this.saoIguais;
        }

        // Método funcional
        public void comparar()
        {
            if (this.valor1 == this.valor2)
            {
                this.saoIguais = true;
            }
            else
            {
                this.saoIguais = false;

                if (this.valor1 > this.valor2)
                {
                    this.maior = this.valor1;
                }
                else
                {
                    this.maior = this.valor2;
                }
            }
        }
    }
}
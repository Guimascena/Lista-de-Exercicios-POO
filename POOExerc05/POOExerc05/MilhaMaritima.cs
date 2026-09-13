using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc05
{
    internal class MilhaMaritima
    {
        // Atributos
        private double milhas;
        private double quilometros;

        // Métodos construtores
        public MilhaMaritima()
        {
            this.milhas = 0;
            this.quilometros = 0;
        }

        public MilhaMaritima(double milhas)
        {
            this.milhas = milhas;
            this.quilometros = 0;
        }

        // Métodos de interface (set/get)
        public void setMilhas(double milhas)
        {
            this.milhas = milhas;
        }

        public double getMilhas()
        {
            return this.milhas;
        }

        public double getQuilometros()
        {
            return this.quilometros;
        }

        // Método funcional
        public void converter()
        {
            this.quilometros = (this.milhas * 1852) / 1000;
        }
    }
}

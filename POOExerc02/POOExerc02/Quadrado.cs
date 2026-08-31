using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOExerc02
{
    internal class Quadrado
    {
        // Atributos
        private int aresta;
        private int area;


        // Métodos Construtores
        public Quadrado()
        {
            this.aresta = 0;
            this.area = 0;
        }

        public Quadrado(int aresta)
        {
            this.aresta= aresta;
            this.area = 0;
        }

        // Métodos de interface (set/get)
        public void setAresta(int aresta)
        {
            this.aresta = aresta;
        }

        public int getAresta()
        {
            return this.aresta;
        }

        public int getArea()
        {
            return this.area;
        }

        // Método funcional
        public void calcular()
        {
            this.area = this.aresta * this.aresta;
        }

    }
}

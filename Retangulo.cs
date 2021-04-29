using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10
{
    public class Retangulo : Figura
    {
        private double _largura;
        private double _altura;
        public double Largura 
        {
            
            get
            {
                return this._largura;
            }

           
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("largura inválida");
                }
                else
                {
                    this._largura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Altura
        {
            
            get
            {
                return this._altura;
            }

           
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("largura inválida");
                }
                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Retangulo(double largura, double altura)
        {
          
            this.Largura = largura;
            this.Altura = altura;
        }
        private void AtualizarArea()
        {
            this._area = this._altura * this._largura;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = 2 *  (this._largura + this._altura);
        }
    }
}

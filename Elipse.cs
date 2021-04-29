using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10
{
    public class Elipse : Figura
    {
        private double _raio1;
        private double _raio2;
        public double Raio1 
        {
            
            get
            {
                return this._raio1;
            }


            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("largura inválida");
                }
                else
                {
                    this._raio1 = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Raio2 
        {
           
            get
            {
                return this._raio2;
            }

            
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("largura inválida");
                }
                else
                {
                    this._raio2 = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Elipse(double raio1, double raio2)
        {
           
            this.Raio1 = raio1;
            this.Raio2 = raio2;
        }
        private void AtualizarArea()
        {
            this._area = this._raio1 * this._raio2 * Math.PI;
        }
        private void AtualizarPerimetro()
        {
            this._perimetro = Math.PI *(3 *(this._raio1 + this._raio2) - Math.Sqrt((3 *this._raio1 + this._raio2)* this._raio1 + 3 * this._raio2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10
{
    public class Figura
    {
        protected double _area; 
        protected double _perimetro; 

        public double Area 
        {
            
            get { return this._area; }
        }

        public double Perimetro 
        {
            
            get { return this._perimetro; }
        }
    }
}
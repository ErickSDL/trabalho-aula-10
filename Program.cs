using System;
using System.Collections.Generic;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Figura, string> figuras = new Dictionary<Figura, string>();
            string caio = "Retangulo";
            string lucas = "Circulo";
            string pablo = "Elipse";


            Elipse toad = new Elipse(20, 25);
            figuras.Add(toad, pablo);

            Circulo circ1 = new Circulo(2.0);

            figuras.Add(circ1, lucas);
           

            Retangulo mario = new Retangulo(15, 20);

            figuras.Add(mario, caio);

            foreach (KeyValuePair<Figura, string> luigi in figuras)
            {
            Console.WriteLine("Figura: {0}", luigi.Value);
            Console.WriteLine("Área:\t\t{0:0.0}", luigi.Key.Area);
            Console.WriteLine("Perímetro\t{0:0.0}", luigi.Key.Perimetro);
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModule2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var formes = new List<Forme>();
            //création d'instance de Cercle avec le constructeur avec valeur passée par défaut
            formes.Add(new Cercle { Rayon = 3 });
            formes.Add(new Rectangle { Largeur = 3, Longueur = 4 });
            formes.Add(new Carre { Longueur = 3 });
            formes.Add(new Triangle { A = 4, B = 5, C = 6 });
            foreach (var forme in formes)
            {
                Console.WriteLine(forme);
            }
            Console.ReadKey();
        }
    }
}

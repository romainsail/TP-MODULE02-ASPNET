namespace TPModule2
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double getAire()
        {
            return Longueur * Largeur;
        }

        public override double getPerimetre()
        {
            return (Longueur + Largeur) * 2;
        }

        public override string ToString()
        {
            return $"\nRectangle de longueur {Longueur} et de largeur { Largeur }\n" +
                $"Aire = {this.getAire()}\n" +
                $"Périmètre = {this.getPerimetre()}\n";
        }
    }
}
namespace TPModule2
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double getAire()
        {
            return this.Longueur * this.Longueur;
        }

        public override double getPerimetre()
        {
            return this.Longueur * 4;
        }

        public override string ToString()
        {
            return $"Carre de coté {Longueur} \nAire = {getAire()}" +
                $"\nPérimètre = {getPerimetre()}";
        }
    }
}
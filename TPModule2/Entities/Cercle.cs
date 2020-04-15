namespace TPModule2
{
    internal class Cercle : Forme
    {
        public int Rayon { get; set; }

        public const double PI = 3.1415926535897931;

        public override double getAire()
        {
            return PI * (Rayon * Rayon);
        }

        public override double getPerimetre()
        {
            return 2 * PI * Rayon;
        }

        public override string ToString()
        {
            return $"Cercle de rayon {this.Rayon} \nAire =  {getAire()} \nPérimètre = {getPerimetre()}";
        }
    }
}
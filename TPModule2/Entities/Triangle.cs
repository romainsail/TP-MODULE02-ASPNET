using System;
using System.Runtime.Remoting.Messaging;

namespace TPModule2
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double getAire()
        {
            double demiPerimetre = this.getPerimetre() / 2;

            return Math.Sqrt(demiPerimetre * (demiPerimetre - this.A) * (demiPerimetre - this.B) * (demiPerimetre - this.C));
        }

        public override double getPerimetre()
        {
            return this.A + this.B + this.C;
        }

        public override String ToString()
        {
            return $"\nTriangle de côté A={this.A}, B={this.B}, C={this.C}\n" +
                $"Aire = {this.getAire()}\n" +
                $"Périmètre = {this.getPerimetre()}\n";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SquareComputing
{   
    public abstract class Figure
    {
        public readonly string FigureName;

        public Figure(string figureName)
        {
            FigureName = figureName;   
        }

        public abstract double GetSquare();
    }
    public class Triangle : Figure
    {
        public readonly double AB;
        public readonly double BC;
        public readonly double CA;

        public Triangle(string figureName, double AB, double BC, double CA) : base(figureName)
        {
            if (AB < 0 || BC < 0 || CA < 0) throw new ArgumentException("Error: The sides of the triangle cannot be less than 0");
            else if ((AB + BC) < CA || (AB + CA) < BC || (BC + CA) < AB) throw new ArgumentException("Error: The sum of the two sides of a triangle cannot be less than the third");
            else
            {
                this.AB = AB;
                this.BC = BC;
                this.CA = CA;
            }
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(AB, 2) == Math.Pow(BC, 2) + Math.Pow(CA, 2)
                || Math.Pow(BC, 2) == Math.Pow(AB, 2) + Math.Pow(CA, 2)
                || Math.Pow(CA, 2) == Math.Pow(AB, 2) + Math.Pow(BC, 2);
        }

        public override double GetSquare()
        {
                double p = (AB + BC + CA) / 2;
                return Math.Round( Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA)),2);
        }
    }
    public class Circle : Figure
    {
        public readonly double Radius;

        public Circle(string figureName, double radius) : base(figureName) 
        {
            if(radius > 0) Radius = radius;
            else throw new ArgumentException("Error: The radius cannot be less than 0");
        }

        public override double GetSquare() 
        {
            return Math.Round( Math.PI * Math.Pow(Radius, 2),2);
        }
    }
}

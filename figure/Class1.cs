using System;
namespace figure
{
    public abstract class figure
    {
        public virtual double area()
        { return -1; }
        public virtual double perimeter()
        { return -1; }
    }
    public class triangle:figure
    { 
        public double a;//сторони трикутника
        public double b;
        public double c;

        public override double perimeter()
        { return (a+b+c); }
        public override double area()
        {
            double p = perimeter() / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
    public class circle : figure
    {
        public double r;//радіус

        public override double perimeter()
        { return 2*Math.PI*r; }
        public override double area()
        {
            return Math.PI*r*r ;
        }
    }
    public class rectangle : figure
    {
        public double a;
        public double b;
        public override double perimeter()
        { return 2*(a+b); }
        public override double area()
        {
            return a*b;
        }

    }
    public class square : figure
    {
        public double a;
        public override double perimeter()
        { return 4 * a; }
        public override double area()
        {
            return a * a;
        }

    }
    public class rhomb : figure
    {
        public double a;
        public double t;
        private double tr;
        public override double perimeter()
        { return 4 * a; }
        public override double area()
        {
            tr = t*(Math.PI / 180);
            return (a *a*Math.Sin(tr));
        }
    }
}

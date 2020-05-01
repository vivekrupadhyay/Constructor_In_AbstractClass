using System;

namespace AbstractClassEx {
    public abstract class Shape {
        protected double x = 10;
        protected double y = 10;
        public Shape () { }
        public Shape (double x, double y) {
            this.x = x;
            this.y = y;
        }
        public abstract double calculateArea ();
    }
    public class square : Shape {
        public square () { }

        public override double calculateArea () {
            return x * y;
        }
    }
    public class rectangle : Shape {

        public rectangle (double x, double y) : base (x, y) {

        }
        public override double calculateArea () {
            return x * y;
        }
    }
    class Program {
        static void Main (string[] args) {
            square obj = new square ();
            double squr = obj.calculateArea ();
            Console.WriteLine (squr);
            rectangle obj1 = new rectangle (12, 21);
            double rectangles = obj1.calculateArea ();
            Console.WriteLine (rectangles);
            Console.ReadLine ();
        }
    }
}
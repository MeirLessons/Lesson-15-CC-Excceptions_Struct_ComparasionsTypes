using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            ref int y = ref x;//5
            x = 10;
            Console.WriteLine(x is int);
            //Car c1 = new Car("Mazata3", "red", 4);
            //Car c2 = new Car("Suzuki", "black", 2);

            //i created with default value = 0
            int i = new int();
            Console.WriteLine(i);
            //Create struct without new keyword
            CarStruct cs3;
            cs3.model = "Mazada";
            cs3.color = "blue";
            cs3.numOfDoors = 4;
            Console.WriteLine(cs3 is ICar);
            Console.WriteLine(cs3.model);

            //Create struct wit new keyword
            ref CarStruct c4 = ref cs3;
            Console.WriteLine(c4.model);
            c4.color = "yellow";

            //create class instance without new keyword
            CarClass cc3;
            //cc3.model = "Mazada";

            Point p = new Point(10, 50);
            Point p2 = new Point(20, 100);
            Rectangle r = new Rectangle(p, p2);

            
        }

    }
    public struct Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Rectangle
    {
        Point topLeftPoint;
        Point bottomRightPoint;

        public Rectangle(Point topLeftPoint, Point bottomRightPoint)
        {
            this.topLeftPoint = topLeftPoint;
            this.bottomRightPoint = bottomRightPoint;
        }
    }

    interface ICar
    {
        void Beep();
    }
    struct  CarStruct : ICar
    {
        public string model;
        public string color;
        public int numOfDoors;

        //בבנאי של "מבנה" חובה לקבל לפחות ארגומנט 1 וחובה לתת ערכים לכל השדות שנמצאות בסקופ
        public CarStruct(string model, int numOfDoors)
        {
            this.model = model;
            this.color = model;
            this.numOfDoors = numOfDoors;
        }

        public void Beep()
        {
            Console.WriteLine("Beeeep");
        }

        public override string ToString()
        {
            return $"model: {model}. color: {color}. num of doors: {numOfDoors}";
        }
    }

    class CarClass : ICar
    {
        public string model;
        public string color;
        public int numOfDoors;

        public CarClass(string model, string color, int numOfDoors)
        {
            this.model = model;
            this.color = color;
            this.numOfDoors = numOfDoors;
        }

        public void Beep()
        {
            Console.WriteLine("Beeeep");
        }

        public override string ToString()
        {
            return $"model: {model}. color: {color}. num of doors: {numOfDoors}";
        }
    }
}

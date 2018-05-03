using System;

namespace ques1
{
    class Program
    {
        public class Car
        {
            private string colour;
            private string make;
            private string gearbox;

            public string GetColour()
            {
                return colour;
            }
            public void SetColour(string col)
            {
                colour = col;
            }
            public string GetMake()
            {
                return make;
            }
            public void SetMake(string mk)
            {
                make = mk;
            }
            public string GetGearox()
            {
                return gearbox;
            }
            public void SetGearbox(string gbox)
            {
                gearbox = gbox;
            }

            public string DescribeCar()
            {
                string description = "\r\nThis car is a " + GetColour() + " " + GetMake() + " with a " + GetGearox() + " transmission";
                return description;
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.Write("Colour: ");
            car.SetColour(Console.ReadLine());
            Console.Write("Make: ");
            car.SetMake(Console.ReadLine());
            Console.Write("Gearbox type: ");
            car.SetGearbox(Console.ReadLine());
            string desc = car.DescribeCar();
            Console.WriteLine(desc);

            Console.ReadKey();
        }
    }
}
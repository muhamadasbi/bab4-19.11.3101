using System;

namespace TheCoffeMechine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CoffePowder coffe = new CoffePowder(1000);
            WaterGalon water = new WaterGalon(10000);
            Milk milk = new Milk(10000);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe,water);
            CoffeMechine cappucino = new CoffeMechine(coffe, water, milk);
            //1
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            string result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check " + cappucino.checkAvailability());
            result = cappucino.makeEsspresso();
            Console.WriteLine("result" + result);
            //2
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" +result);

            Console.WriteLine("check " + cappucino.checkAvailability());
            result = cappucino.makeEsspresso();
            Console.WriteLine("result" + result);
            //3
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result "+result);

            Console.WriteLine("check " + cappucino.checkAvailability());
            result = cappucino.makeEsspresso();
            Console.WriteLine("result" + result);
            //4
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + cappucino.checkAvailability());
            result = cappucino.makeEsspresso();
            Console.WriteLine("result" + result);
            //5
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + cappucino.checkAvailability());
            result = cappucino.makeEsspresso();
            Console.WriteLine("result" + result);
            //6
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + cappucino.checkAvailability());
            result = cappucino.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            Console.WriteLine("check " + cappucino.checkAvailability());
        }
    }
}

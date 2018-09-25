using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using AbstractFactory;
using Builder;
using Adapter;
using Decorator;
using Facade;
namespace DesginPatternsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorPatternDemo();
        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
            Console.WriteLine("next serial: " + generator.NextSerial);
        }

        private static void AbstractFactoryPatternDemo()
        {
            string whatToMake = "road bike";
            AbstractBikeFactory factory = null;

            if (whatToMake.Equals("road bike"))
            {
                factory = new RodeBikeFactory();
            }
            else
            {
                factory = new MountainBikeFactory();
            }

            //create the bike parts
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            //Show what we created
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new DownHill(new WideWheel(24), BikeColor.Green);
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicyle bicyle = director.Build(builder);
            Console.WriteLine(bicyle);
        }

        private static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new NarrowWheel(20));
            wheels.Add(new WideWheel(24));

            UltraWheel ultraWheel = new UltraWheel(24);
            wheels.Add(new UltraWheelAdapater(ultraWheel));

            foreach(IWheel wheel in wheels)
            {
                Console.WriteLine(wheel.ToString());
            }
        }

        private static void DecoratorPatternDemo()
        {
            IBicyle myTourBike = new Touring(new NarrowWheel(34), BikeColor.Blue);
            Console.WriteLine(myTourBike);

            myTourBike = new GoldFrameBike(myTourBike);
            Console.WriteLine(myTourBike);

            myTourBike = new CustomGripBike(myTourBike);
            Console.WriteLine(myTourBike);


        }

        private static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new DownHill(new WideWheel(20), BikeColor.Red));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    class Client
    {

        static CarFlyweightFactory CarFlyweightFactory = new CarFlyweightFactory
        (
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" }
                );


        public static void Execute()
        {

            CarFlyweightFactory.ShowFlyweights();



            var car1 = new Car
            {
                Owner = "John Doe",
                Number = "AMS8786",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Pink"
            };
            car1.CarFlyweight = CarFlyweightFactory.GetFlyweight(car1.CarFlyweight);
            CarFlyweightFactory.ShowFlyweights();

            var car2 = new Car
            {
                Owner = "Ewa Ewowska",
                Number = "AAMS886",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Black"
            };
            car2.CarFlyweight = CarFlyweightFactory.GetFlyweight(car2.CarFlyweight);
            CarFlyweightFactory.ShowFlyweights();

            var car3 = new Car
            {
                Owner = "Ewa Ewowska",
                Number = "ASK99210",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Black"
            };
            car3.CarFlyweight = CarFlyweightFactory.GetFlyweight(car3.CarFlyweight);
            CarFlyweightFactory.ShowFlyweights();


            //car1.CarFlyweight.ShowInfo(car1);
            car1.ShowInfo();

            //car3.Color = "Red";
            var newColorFlyweight = (CarFlyweight)car3.CarFlyweight.Clone();
            newColorFlyweight.Color = "Red";
            car3.CarFlyweight = CarFlyweightFactory.GetFlyweight(newColorFlyweight);

            car2.ShowInfo();
            car3.ShowInfo();

        }
    }
}

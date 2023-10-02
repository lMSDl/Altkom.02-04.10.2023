using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.AbstractFactory
{
    class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory factory, string type, string segment)
        {
            switch(type)
            {
                case nameof(ISedan):
                    _car = factory.ManufactureSedan(segment);
                    break;
                case nameof(ISuv):
                    _car = factory.ManufactureSuv(segment);
                    break;
            }
        }



        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}

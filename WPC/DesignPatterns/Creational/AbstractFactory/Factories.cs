using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.AbstractFactory
{
    public class HondaFactory : ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSedan();
                case "full":
                    return new HondaFullSedan();
                default:
                    throw new Exception();
            }
        }

        public ISuv ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSuv();
                case "full":
                    return new HondaFullSuv();
                default:
                    throw new Exception();
            }
        }
    }

        public class ToyotaFactory : ICarFactory
        {
            public ISedan ManufactureSedan(string segment)
            {
                switch (segment)
                {
                    case "compact":
                        return new ToyotaCompactSedan();
                    case "full":
                        return new ToyotaFullSedan();
                    default:
                        throw new Exception();
                }
            }

            public ISuv ManufactureSuv(string segment)
            {
                switch (segment)
                {
                    case "compact":
                        return new ToyotaCompactSuv();
                    case "full":
                        return new ToyotaFullSuv();
                    default:
                        throw new Exception();
                }
            }
        }
}

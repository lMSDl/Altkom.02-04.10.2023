using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.AbstractFactory
{
    public class HondaCompactSedan : ISedan
    {
        public string Name()
        {
            return "Honda Amaze";
        }
    }

    public class HondaFullSedan : ISedan
    {
        public string Name()
        {
            return "Honda Acord";
        }
    }

    public class HondaCompactSuv : ISuv
    {
        public string Name()
        {
            return "Honda CR-V";
        }
    }

    public class HondaFullSuv : ISuv
    {
        public string Name()
        {
            return "Honda Pilot";
        }
    }

    public class ToyotaCompactSedan : ISedan
    {
        public string Name()
        {
            return "ToyotaCompactSedan";
        }
    }

    public class ToyotaFullSedan : ISedan
    {
        public string Name()
        {
            return "ToyotaFullSedan";
        }
    }

    public class ToyotaCompactSuv : ISuv
    {
        public string Name()
        {
            return "ToyotaCompactSuv";
        }
    }

    public class ToyotaFullSuv : ISuv
    {
        public string Name()
        {
            return "ToyotaFullSuv";
        }
    }
}

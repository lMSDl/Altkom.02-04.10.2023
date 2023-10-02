using System;

namespace WPC.DesignPatterns.Creational.Prototype
{
    public class Address : ICloneable
    {
        public string City { get; set; }
        public string Street { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
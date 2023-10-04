using System;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    public class LogEntity
    {
        public string Message { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }
}
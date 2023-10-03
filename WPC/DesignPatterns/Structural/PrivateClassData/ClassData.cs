using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.PrivateClassData
{
    class ClassData
    {
        private PrivateClassData _privateClassData;

        public ClassData(int intValue, string stringValue)
        {
            _privateClassData = new PrivateClassData(intValue, stringValue);
        }

        public void DoSth()
        {
            _privateClassData.GetIntValue();
            _privateClassData.GetStringValue();
        }
    }
}

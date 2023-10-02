using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.SOLID.I
{
    interface IExcelFormatter
    {
        void ToExcel();
    }
    interface IPdfFormatter
    {
        void ToPdf();
    }

    class Report : IExcelFormatter, IPdfFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }


    /*interface IFormatter
    {
        void ToExcel();
        void ToPdf();
    }

    class Report : IFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IFormatter
    {
        public void ToExcel()
        {
            throw new NotImplementedException();
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }*/
}

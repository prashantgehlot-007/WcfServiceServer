using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceServer
{

    public class DemoService : IDemoService
    {
        public string DoWork()
        {
            return "HelloWorld";
        }

        public string Hi(string fullName)
        {
            return "Hi" + fullName;
        }

        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}

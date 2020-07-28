using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceServer
{
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        string DoWork();

        [OperationContract]
        string Hi(string fullName);

        [OperationContract]
        double Sum(double number1, double number2);


    }
}

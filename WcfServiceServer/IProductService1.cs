﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceServer
{
     
    [ServiceContract]
    public interface IProductService1
    {
        [OperationContract]
        Product find();

        [OperationContract]
        List<Product> findAll();
    }
}

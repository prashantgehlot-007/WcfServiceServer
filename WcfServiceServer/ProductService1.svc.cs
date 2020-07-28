using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceServer
{    
    public class ProductService1 : IProductService1
    {
        public Product find()
        {
            return new Product
            {
                Id = "p01",
                Name = "None",
                Price = 3.2,
                Quantity = 2
            };
        }

        public List<Product> findAll()
        {
            return new List<Product>
            {
               new Product{
                 Id = "p01",
                 Name = "None",
                 Price = 3.2,
                 Quantity = 2
               },
               new Product{
                 Id = "p02",
                 Name = "None02",
                 Price = 5.2,
                 Quantity = 5
               },
               new Product{
                 Id = "p03",
                 Name = "None03",
                 Price = 7.7,
                 Quantity = 25
               },

            };
        }
    }
}

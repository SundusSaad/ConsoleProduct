using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProgram
{
    public enum ProductType
    { 
        Iron = 1,
        Steel = 2,
        Silver = 3
    }

    public enum ProductStage
    {
        Assembly = 1,
        Production = 2,
        Delivery = 3
    }

    internal class Product
    {
        public int ProductId { get; set; } // self generate
        public ProductType ProductType { get; set; }
        public ProductStage ProductStage { get; set; }
    }
}

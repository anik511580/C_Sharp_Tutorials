using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProperty
{
     class Car
    {
        private string color; // variable 

        public string Color //Property - no parameter - no first bracket 
        {
            set { color = value; }
            get { return color; }
        }

        private int price;

        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        public string Model { set; get; }

        



    }
}

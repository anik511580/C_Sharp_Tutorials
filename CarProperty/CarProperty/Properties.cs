using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProperty
{
    class Properties
    {
        private string carLocation;

        public string CarLocation
        {

            set { carLocation = value; }
            get { return carLocation; }

        }

        private string carModelNumber;

        public string CarModelNumber
        {

            set { carModelNumber = value; }
            get { return carModelNumber;  }

        }

        private int carYear;
         
        public int CarYearNumber
        {
            set { carYear = value ; }
            get { return carYear; }

        }

        public float EngineSize { set; get; }
        public int Milage { set; get; }
        public int Price { set; get; }

    }
}

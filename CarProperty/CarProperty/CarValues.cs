using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProperty
{
    class CarValues
    {

        public List<Properties> PutCarDetails ( )
        {
            List<Properties> lstProperties = new List<Properties>();


            Properties objCarProperty = new Properties();
            objCarProperty.CarLocation = "Helsinki";
            objCarProperty.CarModelNumber = "BMW 525";
            objCarProperty.CarYearNumber = 2015;
            objCarProperty.EngineSize = 2;
            objCarProperty.Milage = 150000;
            objCarProperty.Price = 20000;

            lstProperties.Add(objCarProperty);


            Properties objCarProperty2 = new Properties();
            objCarProperty2.CarLocation = "Turku";
            objCarProperty2.CarModelNumber = "Audi A6";
            objCarProperty2.CarYearNumber = 2014;
            objCarProperty2.EngineSize = 2.2f;
            objCarProperty2.Milage = 130000;
            objCarProperty2.Price = 18000;

            lstProperties.Add(objCarProperty2);



            Properties objCarProperty3 = new Properties();
            objCarProperty3.CarLocation = "Tampere";
            objCarProperty3.CarModelNumber = "Marcedes Benz 250E";
            objCarProperty3.CarYearNumber = 2012;
            objCarProperty3.EngineSize = 2.4f;
            objCarProperty3.Milage = 100000;
            objCarProperty3.Price = 20000;

            lstProperties.Add(objCarProperty3);

            return lstProperties;
        }


    }
}

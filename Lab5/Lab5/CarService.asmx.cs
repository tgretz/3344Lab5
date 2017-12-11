using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace Lab5
{
    /// <summary>
    /// Summary description for TestService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]

    public class CarService : System.Web.Services.WebService
    {


        //Web Method to store a Car obj in the database
        //Accepts a Car Object using JSON
        //Returns true if the Insert worked correctly and false if it did not
        [WebMethod]
        public Boolean StoreCar(Car carObj)
        {
            DBConnect objDB = new DBConnect();
            // no pictures yet
            string strSQL = "INSERT INTO Car (VIN, Make, Model, Year, Type, PricePerDay, Availability, Picture) " +
                            "VALUES ('" + carObj.VIN + "', '" + carObj.make + "', '" + carObj.model + "', '" + carObj.year + "', '" + carObj.type + "', '" + carObj.pricePerDay + "', '" + carObj.availability + "', '" + carObj.picture + "')";

            //string strSQL = "INSERT INTO Car (VIN, Make, Model, Year, Type, PricePerDay, Availability) " +
                         //   "VALUES ('" + carObj.VIN + "', '" + carObj.make + "', '" + carObj.model + "', '" + carObj.year + "', '" + carObj.type + "', '" + carObj.pricePerDay + "', '" + carObj.availability + "')";

            //returns number of records affected by the INSERT statement//returns -1 if there was an error
            int result = objDB.DoUpdate(strSQL);

            if (result > 0)
            {
                return true;
            }

            return false;
        }

        //Web Method to get all info for a Car by passing in its VIN
        //returns a Car Obj that contains all the information returned from the Query
        [WebMethod]
        public Car GetCarByVIN(Car carObj)
        {
            DBConnect objDB = new DBConnect();
            string vin = carObj.VIN;
            string strSQL = "SELECT * FROM Car WHERE VIN = '" + vin + "'";
            int recordCount = 0;

            objDB.GetDataSet(strSQL, out recordCount);

            if (recordCount > 0)
            {
                carObj.VIN = objDB.GetField("VIN", 0).ToString();
                carObj.make = objDB.GetField("Make", 0).ToString();
                carObj.model = objDB.GetField("Model", 0).ToString();
                carObj.year = objDB.GetField("Year", 0).ToString();
                carObj.type = objDB.GetField("Type", 0).ToString();
                carObj.pricePerDay = Convert.ToDecimal(objDB.GetField("PricePerDay", 0));
                carObj.availability = Convert.ToBoolean(objDB.GetField("Availability", 0).ToString());
                carObj.picture = objDB.GetField("Picture", 0).ToString();
            }

            return carObj;
        }

        //Web Method to get all cars by type
        //returns list of Car Objs that contain all the information returned from the Query
        [WebMethod]
        public List<Car> GetCarsByType(Car carObj)
        {
            DBConnect objDB = new DBConnect();
            List<Car> carList = new List<Car>();
            string type = carObj.type;
            //Car carObj = new Car();
            string strSQL = "SELECT * FROM Car WHERE Type = '" + type + "'";
            int recordCount = 0;
            objDB.GetDataSet(strSQL, out recordCount);

            for (int i = 0; i < recordCount; i++)
            {
                carObj = new Car();
                carObj.VIN = objDB.GetField("VIN", i).ToString();
                carObj.make = objDB.GetField("Make", i).ToString();
                carObj.model = objDB.GetField("Model", i).ToString();
                carObj.year = objDB.GetField("Year", i).ToString();
                carObj.type = objDB.GetField("Type", i).ToString();
                carObj.pricePerDay = Convert.ToDecimal(objDB.GetField("PricePerDay", i));
                carObj.availability = Convert.ToBoolean(objDB.GetField("Availability", i).ToString());
                carObj.picture = objDB.GetField("Picture", i).ToString();
                carList.Add(carObj);
            }
            return carList;
        }

        // Web Method to change availability of car based on VIN
        [WebMethod]
        public void ChangeAvailability(Car carObj)
        {
            DBConnect objDB = new DBConnect();
            string VIN = carObj.VIN;
            string strSQL = "SELECT Availability FROM Car WHERE VIN = '" + VIN + "'";
            int recordCount = 0;
            Boolean avail = false;
            objDB.GetDataSet(strSQL, out recordCount);

            if (recordCount > 0)
            {
                avail = Convert.ToBoolean(objDB.GetField("Availability", 0).ToString());

                if (avail)
                {
                    strSQL = "UPDATE CAR SET Availability = 'false' WHERE VIN = '" + VIN + "'";
                }
                else if (!avail)
                {
                    strSQL = "UPDATE CAR SET Availability = 'true' WHERE VIN = '" + VIN + "'";
                }
                objDB.DoUpdate(strSQL);
            }
        }

        // Web Method to check if a car is rented/available 
        [WebMethod]
        public Boolean CheckAvailability(Car carObj)
        {
            DBConnect objDB = new DBConnect();
            string VIN = carObj.VIN;
            string strSQL = "SELECT Availability FROM Car WHERE VIN = '" + VIN + "'";
            int recordCount = 0;
            Boolean avail = false;
            objDB.GetDataSet(strSQL, out recordCount);

            //returns true if it's available, false if it's already rented
            if (recordCount > 0)
            {
                avail = Convert.ToBoolean(objDB.GetField("Availability", 0).ToString());
                return avail;
            }
            return false;
        }

    }
}

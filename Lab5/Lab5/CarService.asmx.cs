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

        [WebMethod]
        public TV GetTV(string theShow)
        {
            DBConnect objDB = new DBConnect();
            TV tv = new Lab5.TV();

            string strSQL = "SELECT * FROM TV WHERE Name = '" + theShow + "'";
            int recordCount = 0;

            objDB.GetDataSet(strSQL, out recordCount);

            if (recordCount > 0)
            {
                tv.name = objDB.GetField("Name", 0).ToString();
                tv.genre = objDB.GetField("Genre", 0).ToString();
                tv.seasons = objDB.GetField("Seasons", 0).ToString();
            }

            return tv;
        }

        //Web Method to store a Car obj in the database
        //Accepts a Car Object using JSON
        //Returns true if the Insert worked correctly and false if it did not
        [WebMethod]
        public Boolean StoreCar(Car carObj)
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "INSERT INTO Car (VIN, Make, Model, Year, Type, PricePerDay, Availability, Picture) " +
                            "VALUES ('" + carObj.VIN + "', '" + carObj.make + "', '" + carObj.model + "', '" + carObj.year + "', '" + carObj.type + "', '" + carObj.pricePerDay + "', '" + carObj.availability + "', '" + carObj.picture + "')";

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
        public Car GetCarByVIN(string VIN)
        {
            DBConnect objDB = new DBConnect();
            Car carObj = new Car();
            string strSQL = "SELECT * FROM Car WHERE VIN = '" + VIN + "'";
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
    }
}

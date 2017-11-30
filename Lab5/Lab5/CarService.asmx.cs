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
    }
}

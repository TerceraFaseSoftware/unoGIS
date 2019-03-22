/*Add the packages that we will use during the code*/
using System.Web.Mvc;
using unoGIS.Services.OGC.WMS;
using unoGIS.SpatialObjects;

namespace WMSController4.Controllers
{
    public class WMSController : Controller
    {
        /*Declare a ISpatialDriver variable*/
        static ISpatialDriver driver;
        static WMSController()
        {
            string subPath = @"App_Data\DataExamples\shapefile";
            string fullPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, subPath);

            /*Initialize the variable to connect the type "data.shp" data that we have saved in a folder*/
            driver = new unoGIS.SpatialDrivers.ShapeFileSpatialDriver.ShapefileFolderSpatialDriver
            {
                Connection = new SpatialConnectionBuilder()
                {
                    /*In the DataSource we will put the route of the folder with the data*/
                    DataSource = fullPath
                }
            };
            /*Open the connection*/
            driver.Open();
        }

        public void Index()
        {
            /*To realize the connection of the WMS service, first we will put the specific information of the HTTP,
            * at second, the name that the service will receive 
            * and finally, we will introduce the entities of the data .shp */
            WMSService.Response(this.HttpContext, "Example_Name", driver.EntitySets);
        }
    }
}
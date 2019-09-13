/*Add the packages that we will use during the code*/
using System.Web.Mvc;
using unoGIS.SpatialObjects;
using unoGIS.Services.OGC.WFS;

namespace WFSServices.Controllers
{
    public class WFSController : Controller
    {
        /*Declare a ISpatialDriver variable*/
        static ISpatialDriver driver;
        static WFSController()
        {
            string subPath = @"App_Data\DataExamples\shapefile";
            string fullPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, subPath);

            /*Initialize the variable to connect the type "shapefile" data that we have saved in a folder*/
            driver = new unoGIS.SpatialDrivers.ShapeFileSpatialDriver.ShapefileFolderSpatialDriver
            {
                Connection = new SpatialConnectionBuilder()
                {
                    /*In the DataSource we will put the route of the folder with the data*/
                    DataSource = fullPath
                }
            };

            driver.Open();
        }

        public void Index()
        {
            /*To realize the connection of the WFS service, first we will put the specific information of the HTTP,
             * at second, the name that the service will receive 
             * and finally, we will introduce the entities of the shapefile */
            WFSService.Response(this.HttpContext, "Example_Name", driver.EntitySets);
        }
    }
}
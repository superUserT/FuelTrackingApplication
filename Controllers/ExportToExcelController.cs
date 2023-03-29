using Microsoft.AspNetCore.Mvc;
using Fuel_Tracking_application.Models.Domain;
using Fuel_Tracking_application.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Fuel_Tracking_application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using ClosedXML.Excel;


namespace Fuel_Tracking_application.Controllers
{
    public class ExportToExcelController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            DataSet ds = this.GetFuelData();
            return View(ds);
        }

        [HttpPost]
        public IActionResult Export()
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                DataTable dt = this.GetFuelData().Tables[0];
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.xlsx");
                }
            }
        }
        //Getting fuel data from database method
        private DataSet GetFuelData()
        {
            DataSet ds = new DataSet();
            string constr = "Server=SKYNET;Database=FuelData;Trusted_Connection=True; Trust Server Certificate=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT * FROM FuelData";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(ds);
                    }
                }
            }

            return ds;
        }
    }


}







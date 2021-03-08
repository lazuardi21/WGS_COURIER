using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WGS_COURIER.Models;
using WGS_COURIER.Repositories;
using System.Configuration;

namespace WebApplicationCsharp6.Controllers
{
    public class HomeController : Controller
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Test(int id)
        {
            viewInvoice viewinvoice = new viewInvoice();

            List<INVOICE> list = new List<INVOICE>();

            INVOICERepository rep = new INVOICERepository(connectionString);
            list = rep.GetDataByid(id);

            //List<AA_ACTIVE_THRESHOLD> listActiveThreshold = new List<AA_ACTIVE_THRESHOLD>();
            //AA_ACTIVE_THRESHOLDRepository repActiveThreshold = new AA_ACTIVE_THRESHOLDRepository(connectionStringThreshold);
            //listActiveThreshold = repActiveThreshold.GetData();


            viewinvoice.allInvoice = list;

            //viewThresholds.allAAActiveThreshold = repActiveThreshold.GetData();

            return View("~/Views/Home/Index.cshtml", viewinvoice);
        }



    }
}

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

        private string connectionStringThreshold = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        public ActionResult Index()
        {

            return View();
        }




    }
}

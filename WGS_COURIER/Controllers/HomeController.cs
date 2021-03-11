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

        public ActionResult InvoiceDetailList()
        {
            viewInvoice viewinvoice = new viewInvoice();

            List<INVOICEDETAIL> list = new List<INVOICEDETAIL>();
            INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
            list = rep.GetData();
            //viewinvoice.AllInvoice = list;
            
            return PartialView("~/Views/Home/InvoiceDetailList.cshtml", list);
        }

        public ActionResult InvoiceDetailFiltered(string id)
        {
            //viewInvoice viewinvoice = new viewInvoice();

            List<INVOICEDETAIL> list = new List<INVOICEDETAIL>();
            INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
            list = rep.GetDataByid(id);
            //viewinvoice.AllInvoice = list;

            return PartialView("~/Views/Home/InvoiceDetailList.cshtml", list);
        }


    }
}

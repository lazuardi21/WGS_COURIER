using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using WGS_COURIER.Models;
using WGS_COURIER.Repositories;

namespace WGS_COURIER.Controller
{
	public class INVOICEDETAILController : ApiController
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		[HttpGet]
		public IQueryable<INVOICEDETAIL> Get()
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			List<INVOICEDETAIL> list = rep.GetData();
			return list.AsQueryable();
		}

		[Route("api/INVOICEDETAIL/id/{id}")]
		[HttpGet]
		public IQueryable<INVOICEDETAIL> GetByid(int id)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			List<INVOICEDETAIL> list = rep.GetDataByid(id);
			return list.AsQueryable();
		}

		public void Post(INVOICEDETAIL invoicedetail)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			rep.Add(invoicedetail);
		}

		public void Put(INVOICEDETAIL invoicedetail)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			rep.Update(invoicedetail);
		}

		public void Delete(INVOICEDETAIL invoicedetail)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			rep.Remove(invoicedetail);
		}

	}
}
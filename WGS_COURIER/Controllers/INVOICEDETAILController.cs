using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using WGS_COURIER.Models;
using WGS_COURIER.Repositories;
using Microsoft.AspNetCore.Mvc;

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
		public IQueryable<INVOICEDETAIL> GetByid(string id)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			List<INVOICEDETAIL> list = rep.GetDataByid(id);
			return list.AsQueryable();
			
		}

		[Route("api/INVOICEDETAIL/upload")]
		[HttpPost]
		public IActionResult Upload([FromBody] INVOICEDETAIL invoicedetail)
		{
			Post(invoicedetail);
			return null;
		}

		public void Post(INVOICEDETAIL invoicedetail)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			rep.Add(invoicedetail);
		}

		[Route("api/INVOICEDETAIL/update")]
		[HttpPost]
		public IActionResult Update([FromBody] INVOICEDETAIL invoicedetail)
		{
			Put(invoicedetail);
			return null;
		}

		public void Put(INVOICEDETAIL invoicedetail)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			rep.Update(invoicedetail);
		}

		[Route("api/INVOICEDETAIL/Delete")]
		[HttpPost]
		public IActionResult Delete([FromBody] INVOICEDETAIL invoicedetail)
		{
			Remove(invoicedetail);
			return null;
		}

		public void Remove(INVOICEDETAIL invoicedetail)
		{
			INVOICEDETAILRepository rep = new INVOICEDETAILRepository(connectionString);
			rep.Remove(invoicedetail);
		}

	}
}
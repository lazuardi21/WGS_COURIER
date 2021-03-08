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
	public class INVOICEController : ApiController
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		[HttpGet]
		public IQueryable<INVOICE> Get()
		{
			INVOICERepository rep = new INVOICERepository(connectionString);
			List<INVOICE> list = rep.GetData();
			return list.AsQueryable();
		}

		[Route("api/INVOICE/id/{id}")]
		[HttpGet]
		public IQueryable<INVOICE> GetByid(int id)
		{
			INVOICERepository rep = new INVOICERepository(connectionString);
			List<INVOICE> list = rep.GetDataByid(id);
			return list.AsQueryable();
		}

		public void Post(INVOICE invoice)
		{
			INVOICERepository rep = new INVOICERepository(connectionString);
			rep.Add(invoice);
		}

		public void Put(INVOICE invoice)
		{
			INVOICERepository rep = new INVOICERepository(connectionString);
			rep.Update(invoice);
		}

		public void Delete(INVOICE invoice)
		{
			INVOICERepository rep = new INVOICERepository(connectionString);
			rep.Remove(invoice);
		}

	}
}
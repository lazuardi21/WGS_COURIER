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
	public class SALESController : ApiController
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

		[Route("api/SALES/all")]
		[HttpGet]
		public IQueryable<SALES> Get()
		{
			SALESRepository rep = new SALESRepository(connectionString);
			List<SALES> list = rep.GetData();
			return list.AsQueryable();
		}

		[Route("api/SALES/id/{id}")]
		[HttpGet]
		public IQueryable<SALES> GetByid(int id)
		{
			SALESRepository rep = new SALESRepository(connectionString);
			List<SALES> list = rep.GetDataByid(id);
			return list.AsQueryable();
		}

		public void Post(SALES sales)
		{
			SALESRepository rep = new SALESRepository(connectionString);
			rep.Add(sales);
		}

		public void Put(SALES sales)
		{
			SALESRepository rep = new SALESRepository(connectionString);
			rep.Update(sales);
		}

		public void Delete(SALES sales)
		{
			SALESRepository rep = new SALESRepository(connectionString);
			rep.Remove(sales);
		}

	}
}
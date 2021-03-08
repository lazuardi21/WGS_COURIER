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
	public class COURIERController : ApiController
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		[HttpGet]
		public IQueryable<COURIER> Get()
		{
			COURIERRepository rep = new COURIERRepository(connectionString);
			List<COURIER> list = rep.GetData();
			return list.AsQueryable();
		}

		[Route("api/COURIER/id/{id}")]
		[HttpGet]
		public IQueryable<COURIER> GetByid(int id)
		{
			COURIERRepository rep = new COURIERRepository(connectionString);
			List<COURIER> list = rep.GetDataByid(id);
			return list.AsQueryable();
		}

		public void Post(COURIER courier)
		{
			COURIERRepository rep = new COURIERRepository(connectionString);
			rep.Add(courier);
		}

		public void Put(COURIER courier)
		{
			COURIERRepository rep = new COURIERRepository(connectionString);
			rep.Update(courier);
		}

		public void Delete(COURIER courier)
		{
			COURIERRepository rep = new COURIERRepository(connectionString);
			rep.Remove(courier);
		}

	}
}
using System;
using System.Collections.Generic;

namespace WGS_COURIER.Models
{
	public partial class SALES
	{
		public virtual int? id { get; set; }
		public virtual string sales_name { get; set; }

		public SALES()
		{

		}
	}
}
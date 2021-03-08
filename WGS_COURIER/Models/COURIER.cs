using System;
using System.Collections.Generic;

namespace WGS_COURIER.Models
{
	public partial class COURIER
	{
		public virtual int? id { get; set; }
		public virtual int? courier_name { get; set; }

		public COURIER()
		{

		}
	}
}
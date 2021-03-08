using System;
using System.Collections.Generic;

namespace WGS_COURIER.Models
{
	public partial class INVOICEDETAIL
	{
		public virtual int? id { get; set; }
		public virtual string item { get; set; }
		public virtual double? weight { get; set; }
		public virtual int? qty { get; set; }
		public virtual double? unit_price { get; set; }
		public virtual double? total { get; set; }
		public virtual string no_invoice { get; set; }

		public INVOICEDETAIL()
		{

		}
	}
}
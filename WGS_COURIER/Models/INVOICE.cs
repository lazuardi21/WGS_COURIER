using System;
using System.Collections.Generic;

namespace WGS_COURIER.Models
{
	public partial class INVOICE
	{
		public virtual int? id { get; set; }
		public virtual int? invoice_date { get; set; }
		public virtual string t_o { get; set; }
		public virtual string ship_to { get; set; }
		public virtual int? payment_type { get; set; }
		public virtual string sales_name { get; set; }
		public virtual int? courier_name { get; set; }

		public INVOICE()
		{

		}
	}
}
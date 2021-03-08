using System;
using System.Collections.Generic;

namespace WGS_COURIER.Models
{
	public partial class INVOICE
	{
		public virtual int? id { get; set; }
		public virtual DateTime? invoice_date { get; set; }
		public virtual string t_o { get; set; }
		public virtual string ship_to { get; set; }
		public virtual string payment_type { get; set; }
		public virtual string sales_name { get; set; }
		public virtual string courier_name { get; set; }
		public virtual string no_invoice { get; set; }

		public INVOICE()
		{
			
		}
	}
}
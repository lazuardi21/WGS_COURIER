using System;
using System.Collections.Generic;

namespace WGS_COURIER.Models
{
	public partial class INVOICEDETAIL
	{
		public virtual int? id { get; set; }
		public virtual string code_id { get; set; }
		public virtual string metric_name { get; set; }
		public virtual int? threshold { get; set; }
		public virtual DateTime? created_at { get; set; }
		public virtual DateTime? updated_at { get; set; }

		public INVOICEDETAIL()
		{

		}
	}
}
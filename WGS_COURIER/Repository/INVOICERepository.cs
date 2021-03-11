using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WGS_COURIER.Models;

namespace WGS_COURIER.Repositories
{
	public partial class INVOICERepository
	{
		private string connString;
		public string Message { get; set; }

		public INVOICERepository(string connectionString)
		{
			connString = connectionString;
		}

		public void Add(INVOICE invoice)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("INSERT INTO Invoice ( [invoice_date], [t_o], [ship_to], [payment_type], [sales_name], [courier_name], [no_invoice]) VALUES(@invoice_date, @t_o, @ship_to, @payment_type, @sales_name, @courier_name, @no_invoice)", conn);
					command.CommandType = System.Data.CommandType.Text;
					//if (invoice.id != null) { command.Parameters.AddWithValue("@id", invoice.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (invoice.invoice_date != null) { command.Parameters.AddWithValue("@invoice_date", invoice.invoice_date); } else { command.Parameters.AddWithValue("@invoice_date", DBNull.Value); } 
					if (invoice.t_o != null) { command.Parameters.AddWithValue("@t_o", invoice.t_o); } else { command.Parameters.AddWithValue("@t_o", DBNull.Value); } 
					if (invoice.ship_to != null) { command.Parameters.AddWithValue("@ship_to", invoice.ship_to); } else { command.Parameters.AddWithValue("@ship_to", DBNull.Value); } 
					if (invoice.payment_type != null) { command.Parameters.AddWithValue("@payment_type", invoice.payment_type); } else { command.Parameters.AddWithValue("@payment_type", DBNull.Value); } 
					if (invoice.sales_name != null) { command.Parameters.AddWithValue("@sales_name", invoice.sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
					if (invoice.courier_name != null) { command.Parameters.AddWithValue("@courier_name", invoice.courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
					if (invoice.no_invoice != null) { command.Parameters.AddWithValue("@no_invoice", invoice.no_invoice); } else { command.Parameters.AddWithValue("@no_invoice", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void AddMany(List<INVOICE> invoice)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					int pos = 0;
					foreach(INVOICE item in invoice)
					{
						SqlCommand command = new SqlCommand("INSERT INTO Invoice ([id], [invoice_date], [t_o], [ship_to], [payment_type], [sales_name], [courier_name], [no_invoice]) VALUES(@id, @invoice_date, @t_o, @ship_to, @payment_type, @sales_name, @courier_name, @no_invoice)", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (invoice[pos].id != null) { command.Parameters.AddWithValue("@id", invoice[pos].id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (invoice[pos].invoice_date != null) { command.Parameters.AddWithValue("@invoice_date", invoice[pos].invoice_date); } else { command.Parameters.AddWithValue("@invoice_date", DBNull.Value); } 
						if (invoice[pos].t_o != null) { command.Parameters.AddWithValue("@t_o", invoice[pos].t_o); } else { command.Parameters.AddWithValue("@t_o", DBNull.Value); } 
						if (invoice[pos].ship_to != null) { command.Parameters.AddWithValue("@ship_to", invoice[pos].ship_to); } else { command.Parameters.AddWithValue("@ship_to", DBNull.Value); } 
						if (invoice[pos].payment_type != null) { command.Parameters.AddWithValue("@payment_type", invoice[pos].payment_type); } else { command.Parameters.AddWithValue("@payment_type", DBNull.Value); } 
						if (invoice[pos].sales_name != null) { command.Parameters.AddWithValue("@sales_name", invoice[pos].sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
						if (invoice[pos].courier_name != null) { command.Parameters.AddWithValue("@courier_name", invoice[pos].courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
						if (invoice[pos].no_invoice != null) { command.Parameters.AddWithValue("@no_invoice", invoice[pos].no_invoice); } else { command.Parameters.AddWithValue("@no_invoice", DBNull.Value); } 
						command.ExecuteNonQuery();
						pos = pos + 1;
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void Update(INVOICE invoice)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("UPDATE Invoice SET invoice_date = @invoice_date, t_o = @t_o, ship_to = @ship_to, payment_type = @payment_type, sales_name = @sales_name, courier_name = @courier_name, no_invoice = @no_invoice WHERE id = @id", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (invoice.id != null) { command.Parameters.AddWithValue("@id", invoice.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (invoice.invoice_date != null) { command.Parameters.AddWithValue("@invoice_date", invoice.invoice_date); } else { command.Parameters.AddWithValue("@invoice_date", DBNull.Value); } 
					if (invoice.t_o != null) { command.Parameters.AddWithValue("@t_o", invoice.t_o); } else { command.Parameters.AddWithValue("@t_o", DBNull.Value); } 
					if (invoice.ship_to != null) { command.Parameters.AddWithValue("@ship_to", invoice.ship_to); } else { command.Parameters.AddWithValue("@ship_to", DBNull.Value); } 
					if (invoice.payment_type != null) { command.Parameters.AddWithValue("@payment_type", invoice.payment_type); } else { command.Parameters.AddWithValue("@payment_type", DBNull.Value); } 
					if (invoice.sales_name != null) { command.Parameters.AddWithValue("@sales_name", invoice.sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
					if (invoice.courier_name != null) { command.Parameters.AddWithValue("@courier_name", invoice.courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
					if (invoice.no_invoice != null) { command.Parameters.AddWithValue("@no_invoice", invoice.no_invoice); } else { command.Parameters.AddWithValue("@no_invoice", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void UpdateMany(List<INVOICE> invoices)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					foreach(INVOICE item in invoices)
					{
						SqlCommand command = new SqlCommand("UPDATE Invoice SET invoice_date = @invoice_date, t_o = @t_o, ship_to = @ship_to, payment_type = @payment_type, sales_name = @sales_name, courier_name = @courier_name, no_invoice = @no_invoice WHERE id = @id", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (item.id != null) { command.Parameters.AddWithValue("@id", item.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (item.invoice_date != null) { command.Parameters.AddWithValue("@invoice_date", item.invoice_date); } else { command.Parameters.AddWithValue("@invoice_date", DBNull.Value); } 
						if (item.t_o != null) { command.Parameters.AddWithValue("@t_o", item.t_o); } else { command.Parameters.AddWithValue("@t_o", DBNull.Value); } 
						if (item.ship_to != null) { command.Parameters.AddWithValue("@ship_to", item.ship_to); } else { command.Parameters.AddWithValue("@ship_to", DBNull.Value); } 
						if (item.payment_type != null) { command.Parameters.AddWithValue("@payment_type", item.payment_type); } else { command.Parameters.AddWithValue("@payment_type", DBNull.Value); } 
						if (item.sales_name != null) { command.Parameters.AddWithValue("@sales_name", item.sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
						if (item.courier_name != null) { command.Parameters.AddWithValue("@courier_name", item.courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
						if (item.no_invoice != null) { command.Parameters.AddWithValue("@no_invoice", item.no_invoice); } else { command.Parameters.AddWithValue("@no_invoice", DBNull.Value); } 
						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void Remove(INVOICE id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE Invoice WHERE id = @id", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (id.id != null) { command.Parameters.AddWithValue("@id", id.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public List<INVOICE> GetData()
		{
			List<INVOICE> items = new List<INVOICE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [invoice_date], [t_o], [ship_to], [payment_type], [sales_name], [courier_name], [no_invoice] FROM Invoice", conn);
					SqlDataReader reader = command.ExecuteReader();
					INVOICE item = new INVOICE();
					while(reader.Read())
					{
						item = new INVOICE();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.invoice_date = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.t_o = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.ship_to = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.payment_type = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.sales_name = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.courier_name = Convert.ToString(reader[6]); }
						if (reader[7] != DBNull.Value) { item.no_invoice = Convert.ToString(reader[7]); }
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<INVOICE> GetDataByid(int id)
		{
			List<INVOICE> items = new List<INVOICE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [invoice_date], [t_o], [ship_to], [payment_type], [sales_name], [courier_name], [no_invoice] FROM Invoice WHERE no_invoice = @id", conn);
					command.Parameters.AddWithValue("@id", id);
					SqlDataReader reader = command.ExecuteReader();
					INVOICE item = new INVOICE();
					while(reader.Read())
					{
						item = new INVOICE();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.invoice_date = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.t_o = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.ship_to = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.payment_type = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.sales_name = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.courier_name = Convert.ToString(reader[6]); }
						if (reader[7] != DBNull.Value) { item.no_invoice = Convert.ToString(reader[7]); }
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public void RemoveByid(int id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE Invoice WHERE id = @id", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (id != 0) { command.Parameters.AddWithValue("@id", id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public DataTable GetDataTable(List<INVOICE> invoice)
		{
			DataTable dt = new DataTable("INVOICE");

			DataColumn c1 = new DataColumn("id", typeof(int)); 
			dt.Columns.Add(c1);
			DataColumn c2 = new DataColumn("invoice_date", typeof(DateTime)); c2.AllowDBNull = true;
			dt.Columns.Add(c2);
			DataColumn c3 = new DataColumn("t_o", typeof(string)); c3.AllowDBNull = true;
			dt.Columns.Add(c3);
			DataColumn c4 = new DataColumn("ship_to", typeof(string)); c4.AllowDBNull = true;
			dt.Columns.Add(c4);
			DataColumn c5 = new DataColumn("payment_type", typeof(string)); c5.AllowDBNull = true;
			dt.Columns.Add(c5);
			DataColumn c6 = new DataColumn("sales_name", typeof(string)); c6.AllowDBNull = true;
			dt.Columns.Add(c6);
			DataColumn c7 = new DataColumn("courier_name", typeof(string)); c7.AllowDBNull = true;
			dt.Columns.Add(c7);
			DataColumn c8 = new DataColumn("no_invoice", typeof(string)); c8.AllowDBNull = true;
			dt.Columns.Add(c8);

			foreach (INVOICE v in invoice)
			{
				DataRow dr = dt.NewRow();
				if (v.id != null) { dr[0] = v.id; } else { dr[0] = DBNull.Value; }
				if (v.invoice_date != null) { dr[1] = v.invoice_date; } else { dr[1] = DBNull.Value; }
				if (v.t_o != null) { dr[2] = v.t_o; } else { dr[2] = DBNull.Value; }
				if (v.ship_to != null) { dr[3] = v.ship_to; } else { dr[3] = DBNull.Value; }
				if (v.payment_type != null) { dr[4] = v.payment_type; } else { dr[4] = DBNull.Value; }
				if (v.sales_name != null) { dr[5] = v.sales_name; } else { dr[5] = DBNull.Value; }
				if (v.courier_name != null) { dr[6] = v.courier_name; } else { dr[6] = DBNull.Value; }
				if (v.no_invoice != null) { dr[7] = v.no_invoice; } else { dr[7] = DBNull.Value; }
				dt.Rows.Add(dr);
			}
			dt.AcceptChanges();

			return dt;
		}

		public void AddManyBulk(List<INVOICE> invoice)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();

					DataTable dt = GetDataTable(invoice);
					using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connString))
					{
						bulkCopy.DestinationTableName = dt.TableName;
						bulkCopy.WriteToServer(dt);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

	}
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WGS_COURIER.Models;

namespace WGS_COURIER.Repositories
{
	public partial class INVOICEDETAILRepository
	{
		private string connString;
		public string Message { get; set; }

		public INVOICEDETAILRepository(string connectionString)
		{
			connString = connectionString;
		}

		public void Add(INVOICEDETAIL invoicedetail)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("INSERT INTO invoiceDetail ([item], [weight], [qty], [unit_price], [total], [no_invoice]) VALUES( @item, @weight, @qty, @unit_price, @total, @no_invoice)", conn);
					command.CommandType = System.Data.CommandType.Text;
					//if (invoicedetail.id != null) { command.Parameters.AddWithValue("@id", invoicedetail.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (invoicedetail.item != null) { command.Parameters.AddWithValue("@item", invoicedetail.item); } else { command.Parameters.AddWithValue("@item", DBNull.Value); } 
					if (invoicedetail.weight != null) { command.Parameters.AddWithValue("@weight", invoicedetail.weight); } else { command.Parameters.AddWithValue("@weight", DBNull.Value); } 
					if (invoicedetail.qty != null) { command.Parameters.AddWithValue("@qty", invoicedetail.qty); } else { command.Parameters.AddWithValue("@qty", DBNull.Value); } 
					if (invoicedetail.unit_price != null) { command.Parameters.AddWithValue("@unit_price", invoicedetail.unit_price); } else { command.Parameters.AddWithValue("@unit_price", DBNull.Value); } 
					if (invoicedetail.total != null) { command.Parameters.AddWithValue("@total", invoicedetail.total); } else { command.Parameters.AddWithValue("@total", DBNull.Value); } 
					if (invoicedetail.no_invoice != null) { command.Parameters.AddWithValue("@no_invoice", invoicedetail.no_invoice); } else { command.Parameters.AddWithValue("@no_invoice", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void AddMany(List<INVOICEDETAIL> invoicedetail)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					int pos = 0;
					foreach(INVOICEDETAIL item in invoicedetail)
					{
						SqlCommand command = new SqlCommand("INSERT INTO invoiceDetail ([id], [item], [weight], [qty], [unit_price], [total], [no_invoice]) VALUES(@id, @item, @weight, @qty, @unit_price, @total, @no_invoice)", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (invoicedetail[pos].id != null) { command.Parameters.AddWithValue("@id", invoicedetail[pos].id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (invoicedetail[pos].item != null) { command.Parameters.AddWithValue("@item", invoicedetail[pos].item); } else { command.Parameters.AddWithValue("@item", DBNull.Value); } 
						if (invoicedetail[pos].weight != null) { command.Parameters.AddWithValue("@weight", invoicedetail[pos].weight); } else { command.Parameters.AddWithValue("@weight", DBNull.Value); } 
						if (invoicedetail[pos].qty != null) { command.Parameters.AddWithValue("@qty", invoicedetail[pos].qty); } else { command.Parameters.AddWithValue("@qty", DBNull.Value); } 
						if (invoicedetail[pos].unit_price != null) { command.Parameters.AddWithValue("@unit_price", invoicedetail[pos].unit_price); } else { command.Parameters.AddWithValue("@unit_price", DBNull.Value); } 
						if (invoicedetail[pos].total != null) { command.Parameters.AddWithValue("@total", invoicedetail[pos].total); } else { command.Parameters.AddWithValue("@total", DBNull.Value); } 
						if (invoicedetail[pos].no_invoice != null) { command.Parameters.AddWithValue("@no_invoice", invoicedetail[pos].no_invoice); } else { command.Parameters.AddWithValue("@no_invoice", DBNull.Value); } 
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

		public void Update(INVOICEDETAIL invoicedetail)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("UPDATE invoiceDetail SET item = @item, weight = @weight, qty = @qty, unit_price = @unit_price, total = @total, no_invoice = @no_invoice WHERE id = @id", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (invoicedetail.id != null) { command.Parameters.AddWithValue("@id", invoicedetail.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (invoicedetail.item != null) { command.Parameters.AddWithValue("@item", invoicedetail.item); } else { command.Parameters.AddWithValue("@item", DBNull.Value); } 
					if (invoicedetail.weight != null) { command.Parameters.AddWithValue("@weight", invoicedetail.weight); } else { command.Parameters.AddWithValue("@weight", DBNull.Value); } 
					if (invoicedetail.qty != null) { command.Parameters.AddWithValue("@qty", invoicedetail.qty); } else { command.Parameters.AddWithValue("@qty", DBNull.Value); } 
					if (invoicedetail.unit_price != null) { command.Parameters.AddWithValue("@unit_price", invoicedetail.unit_price); } else { command.Parameters.AddWithValue("@unit_price", DBNull.Value); } 
					if (invoicedetail.total != null) { command.Parameters.AddWithValue("@total", invoicedetail.total); } else { command.Parameters.AddWithValue("@total", DBNull.Value); } 
					if (invoicedetail.no_invoice != null) { command.Parameters.AddWithValue("@no_invoice", invoicedetail.no_invoice); } else { command.Parameters.AddWithValue("@no_invoice", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void UpdateMany(List<INVOICEDETAIL> invoicedetails)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					foreach(INVOICEDETAIL item in invoicedetails)
					{
						SqlCommand command = new SqlCommand("UPDATE invoiceDetail SET item = @item, weight = @weight, qty = @qty, unit_price = @unit_price, total = @total, no_invoice = @no_invoice WHERE id = @id", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (item.id != null) { command.Parameters.AddWithValue("@id", item.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (item.item != null) { command.Parameters.AddWithValue("@item", item.item); } else { command.Parameters.AddWithValue("@item", DBNull.Value); } 
						if (item.weight != null) { command.Parameters.AddWithValue("@weight", item.weight); } else { command.Parameters.AddWithValue("@weight", DBNull.Value); } 
						if (item.qty != null) { command.Parameters.AddWithValue("@qty", item.qty); } else { command.Parameters.AddWithValue("@qty", DBNull.Value); } 
						if (item.unit_price != null) { command.Parameters.AddWithValue("@unit_price", item.unit_price); } else { command.Parameters.AddWithValue("@unit_price", DBNull.Value); } 
						if (item.total != null) { command.Parameters.AddWithValue("@total", item.total); } else { command.Parameters.AddWithValue("@total", DBNull.Value); } 
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

		public void Remove(INVOICEDETAIL id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE invoiceDetail WHERE id = @id", conn);
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

		public List<INVOICEDETAIL> GetData()
		{
			List<INVOICEDETAIL> items = new List<INVOICEDETAIL>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [item], [weight], [qty], [unit_price], [total], [no_invoice] FROM invoiceDetail", conn);
					SqlDataReader reader = command.ExecuteReader();
					INVOICEDETAIL item = new INVOICEDETAIL();
					while(reader.Read())
					{
						item = new INVOICEDETAIL();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.item = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.weight = Convert.ToDouble(reader[2]); }
						if (reader[3] != DBNull.Value) { item.qty = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.unit_price = Convert.ToDouble(reader[4]); }
						if (reader[5] != DBNull.Value) { item.total = Convert.ToDouble(reader[5]); }
						if (reader[6] != DBNull.Value) { item.no_invoice = Convert.ToString(reader[6]); }
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

		public List<INVOICEDETAIL> GetDataByid(string id)
		{
			List<INVOICEDETAIL> items = new List<INVOICEDETAIL>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [item], [weight], [qty], [unit_price], [total],[no_invoice] FROM invoiceDetail WHERE no_invoice = @id", conn);
					command.Parameters.AddWithValue("@id", id);
					SqlDataReader reader = command.ExecuteReader();
					INVOICEDETAIL item = new INVOICEDETAIL();
					while(reader.Read())
					{
						item = new INVOICEDETAIL();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.item = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.weight = Convert.ToDouble(reader[2]); }
						if (reader[3] != DBNull.Value) { item.qty = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.unit_price = Convert.ToDouble(reader[4]); }
						if (reader[5] != DBNull.Value) { item.total = Convert.ToDouble(reader[5]); }
						if (reader[6] != DBNull.Value) { item.no_invoice = Convert.ToString(reader[6]); }
						
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
					SqlCommand command = new SqlCommand("DELETE invoiceDetail WHERE id = @id", conn);
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

		public DataTable GetDataTable(List<INVOICEDETAIL> invoicedetail)
		{
			DataTable dt = new DataTable("INVOICEDETAIL");

			DataColumn c1 = new DataColumn("id", typeof(int)); 
			dt.Columns.Add(c1);
			DataColumn c2 = new DataColumn("item", typeof(string)); c2.AllowDBNull = true;
			dt.Columns.Add(c2);
			DataColumn c3 = new DataColumn("weight", typeof(double)); c3.AllowDBNull = true;
			dt.Columns.Add(c3);
			DataColumn c4 = new DataColumn("qty", typeof(int)); c4.AllowDBNull = true;
			dt.Columns.Add(c4);
			DataColumn c5 = new DataColumn("unit_price", typeof(double)); c5.AllowDBNull = true;
			dt.Columns.Add(c5);
			DataColumn c6 = new DataColumn("total", typeof(double)); c6.AllowDBNull = true;
			dt.Columns.Add(c6);
			DataColumn c7 = new DataColumn("no_invoice", typeof(string)); c7.AllowDBNull = true;
			dt.Columns.Add(c7);

			foreach (INVOICEDETAIL v in invoicedetail)
			{
				DataRow dr = dt.NewRow();
				if (v.id != null) { dr[0] = v.id; } else { dr[0] = DBNull.Value; }
				if (v.item != null) { dr[1] = v.item; } else { dr[1] = DBNull.Value; }
				if (v.weight != null) { dr[2] = v.weight; } else { dr[2] = DBNull.Value; }
				if (v.qty != null) { dr[3] = v.qty; } else { dr[3] = DBNull.Value; }
				if (v.unit_price != null) { dr[4] = v.unit_price; } else { dr[4] = DBNull.Value; }
				if (v.total != null) { dr[5] = v.total; } else { dr[5] = DBNull.Value; }
				if (v.no_invoice != null) { dr[6] = v.no_invoice; } else { dr[6] = DBNull.Value; }
				dt.Rows.Add(dr);
			}
			dt.AcceptChanges();

			return dt;
		}

		public void AddManyBulk(List<INVOICEDETAIL> invoicedetail)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();

					DataTable dt = GetDataTable(invoicedetail);
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
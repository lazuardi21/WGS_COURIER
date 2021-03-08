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
					SqlCommand command = new SqlCommand("INSERT INTO invoiceDetail ([id], [code_id], [metric_name], [threshold], [created_at], [updated_at]) VALUES(@id, @code_id, @metric_name, @threshold, @created_at, @updated_at)", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (invoicedetail.id != null) { command.Parameters.AddWithValue("@id", invoicedetail.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (invoicedetail.code_id != null) { command.Parameters.AddWithValue("@code_id", invoicedetail.code_id); } else { command.Parameters.AddWithValue("@code_id", DBNull.Value); } 
					if (invoicedetail.metric_name != null) { command.Parameters.AddWithValue("@metric_name", invoicedetail.metric_name); } else { command.Parameters.AddWithValue("@metric_name", DBNull.Value); } 
					if (invoicedetail.threshold != null) { command.Parameters.AddWithValue("@threshold", invoicedetail.threshold); } else { command.Parameters.AddWithValue("@threshold", DBNull.Value); } 
					if (invoicedetail.created_at != null) { command.Parameters.AddWithValue("@created_at", invoicedetail.created_at); } else { command.Parameters.AddWithValue("@created_at", DBNull.Value); } 
					if (invoicedetail.updated_at != null) { command.Parameters.AddWithValue("@updated_at", invoicedetail.updated_at); } else { command.Parameters.AddWithValue("@updated_at", DBNull.Value); } 
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
						SqlCommand command = new SqlCommand("INSERT INTO invoiceDetail ([id], [code_id], [metric_name], [threshold], [created_at], [updated_at]) VALUES(@id, @code_id, @metric_name, @threshold, @created_at, @updated_at)", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (invoicedetail[pos].id != null) { command.Parameters.AddWithValue("@id", invoicedetail[pos].id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (invoicedetail[pos].code_id != null) { command.Parameters.AddWithValue("@code_id", invoicedetail[pos].code_id); } else { command.Parameters.AddWithValue("@code_id", DBNull.Value); } 
						if (invoicedetail[pos].metric_name != null) { command.Parameters.AddWithValue("@metric_name", invoicedetail[pos].metric_name); } else { command.Parameters.AddWithValue("@metric_name", DBNull.Value); } 
						if (invoicedetail[pos].threshold != null) { command.Parameters.AddWithValue("@threshold", invoicedetail[pos].threshold); } else { command.Parameters.AddWithValue("@threshold", DBNull.Value); } 
						if (invoicedetail[pos].created_at != null) { command.Parameters.AddWithValue("@created_at", invoicedetail[pos].created_at); } else { command.Parameters.AddWithValue("@created_at", DBNull.Value); } 
						if (invoicedetail[pos].updated_at != null) { command.Parameters.AddWithValue("@updated_at", invoicedetail[pos].updated_at); } else { command.Parameters.AddWithValue("@updated_at", DBNull.Value); } 
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
					SqlCommand command = new SqlCommand("UPDATE invoiceDetail SET code_id = @code_id, metric_name = @metric_name, threshold = @threshold, created_at = @created_at, updated_at = @updated_at WHERE id = @id", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (invoicedetail.id != null) { command.Parameters.AddWithValue("@id", invoicedetail.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (invoicedetail.code_id != null) { command.Parameters.AddWithValue("@code_id", invoicedetail.code_id); } else { command.Parameters.AddWithValue("@code_id", DBNull.Value); } 
					if (invoicedetail.metric_name != null) { command.Parameters.AddWithValue("@metric_name", invoicedetail.metric_name); } else { command.Parameters.AddWithValue("@metric_name", DBNull.Value); } 
					if (invoicedetail.threshold != null) { command.Parameters.AddWithValue("@threshold", invoicedetail.threshold); } else { command.Parameters.AddWithValue("@threshold", DBNull.Value); } 
					if (invoicedetail.created_at != null) { command.Parameters.AddWithValue("@created_at", invoicedetail.created_at); } else { command.Parameters.AddWithValue("@created_at", DBNull.Value); } 
					if (invoicedetail.updated_at != null) { command.Parameters.AddWithValue("@updated_at", invoicedetail.updated_at); } else { command.Parameters.AddWithValue("@updated_at", DBNull.Value); } 
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
						SqlCommand command = new SqlCommand("UPDATE invoiceDetail SET code_id = @code_id, metric_name = @metric_name, threshold = @threshold, created_at = @created_at, updated_at = @updated_at WHERE id = @id", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (item.id != null) { command.Parameters.AddWithValue("@id", item.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (item.code_id != null) { command.Parameters.AddWithValue("@code_id", item.code_id); } else { command.Parameters.AddWithValue("@code_id", DBNull.Value); } 
						if (item.metric_name != null) { command.Parameters.AddWithValue("@metric_name", item.metric_name); } else { command.Parameters.AddWithValue("@metric_name", DBNull.Value); } 
						if (item.threshold != null) { command.Parameters.AddWithValue("@threshold", item.threshold); } else { command.Parameters.AddWithValue("@threshold", DBNull.Value); } 
						if (item.created_at != null) { command.Parameters.AddWithValue("@created_at", item.created_at); } else { command.Parameters.AddWithValue("@created_at", DBNull.Value); } 
						if (item.updated_at != null) { command.Parameters.AddWithValue("@updated_at", item.updated_at); } else { command.Parameters.AddWithValue("@updated_at", DBNull.Value); } 
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
					SqlCommand command = new SqlCommand("SELECT [id], [code_id], [metric_name], [threshold], [created_at], [updated_at] FROM invoiceDetail", conn);
					SqlDataReader reader = command.ExecuteReader();
					INVOICEDETAIL item = new INVOICEDETAIL();
					while(reader.Read())
					{
						item = new INVOICEDETAIL();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.code_id = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.metric_name = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.threshold = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.created_at = Convert.ToDateTime(reader[4]); }
						if (reader[5] != DBNull.Value) { item.updated_at = Convert.ToDateTime(reader[5]); }
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

		public List<INVOICEDETAIL> GetDataByid(int id)
		{
			List<INVOICEDETAIL> items = new List<INVOICEDETAIL>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [code_id], [metric_name], [threshold], [created_at], [updated_at] FROM invoiceDetail WHERE id = @id", conn);
					command.Parameters.AddWithValue("@id", id);
					SqlDataReader reader = command.ExecuteReader();
					INVOICEDETAIL item = new INVOICEDETAIL();
					while(reader.Read())
					{
						item = new INVOICEDETAIL();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.code_id = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.metric_name = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.threshold = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.created_at = Convert.ToDateTime(reader[4]); }
						if (reader[5] != DBNull.Value) { item.updated_at = Convert.ToDateTime(reader[5]); }
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
					if (id != null) { command.Parameters.AddWithValue("@id", id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
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
			DataColumn c2 = new DataColumn("code_id", typeof(string)); c2.AllowDBNull = true;
			dt.Columns.Add(c2);
			DataColumn c3 = new DataColumn("metric_name", typeof(string)); c3.AllowDBNull = true;
			dt.Columns.Add(c3);
			DataColumn c4 = new DataColumn("threshold", typeof(int)); c4.AllowDBNull = true;
			dt.Columns.Add(c4);
			DataColumn c5 = new DataColumn("created_at", typeof(DateTime)); c5.AllowDBNull = true;
			dt.Columns.Add(c5);
			DataColumn c6 = new DataColumn("updated_at", typeof(DateTime)); c6.AllowDBNull = true;
			dt.Columns.Add(c6);

			foreach (INVOICEDETAIL v in invoicedetail)
			{
				DataRow dr = dt.NewRow();
				if (v.id != null) { dr[0] = v.id; } else { dr[0] = DBNull.Value; }
				if (v.code_id != null) { dr[1] = v.code_id; } else { dr[1] = DBNull.Value; }
				if (v.metric_name != null) { dr[2] = v.metric_name; } else { dr[2] = DBNull.Value; }
				if (v.threshold != null) { dr[3] = v.threshold; } else { dr[3] = DBNull.Value; }
				if (v.created_at != null) { dr[4] = v.created_at; } else { dr[4] = DBNull.Value; }
				if (v.updated_at != null) { dr[5] = v.updated_at; } else { dr[5] = DBNull.Value; }
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WGS_COURIER.Models;

namespace WGS_COURIER.Repositories
{
	public partial class SALESRepository
	{
		private string connString;
		public string Message { get; set; }

		public SALESRepository(string connectionString)
		{
			connString = connectionString;
		}

		public void Add(SALES sales)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("INSERT INTO Sales ([id], [sales_name]) VALUES(@id, @sales_name)", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (sales.id != null) { command.Parameters.AddWithValue("@id", sales.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (sales.sales_name != null) { command.Parameters.AddWithValue("@sales_name", sales.sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void AddMany(List<SALES> sales)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					int pos = 0;
					foreach(SALES item in sales)
					{
						SqlCommand command = new SqlCommand("INSERT INTO Sales ([id], [sales_name]) VALUES(@id, @sales_name)", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (sales[pos].id != null) { command.Parameters.AddWithValue("@id", sales[pos].id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (sales[pos].sales_name != null) { command.Parameters.AddWithValue("@sales_name", sales[pos].sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
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

		public void Update(SALES sales)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("UPDATE Sales SET  WHERE id = @id AND sales_name = @sales_name", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (sales.id != null) { command.Parameters.AddWithValue("@id", sales.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (sales.sales_name != null) { command.Parameters.AddWithValue("@sales_name", sales.sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void UpdateMany(List<SALES> saless)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					foreach(SALES item in saless)
					{
						SqlCommand command = new SqlCommand("UPDATE Sales SET  WHERE id = @id AND sales_name = @sales_name", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (item.id != null) { command.Parameters.AddWithValue("@id", item.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (item.sales_name != null) { command.Parameters.AddWithValue("@sales_name", item.sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void Remove(SALES id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE Sales WHERE id = @id AND sales_name = @sales_name", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (id.id != null) { command.Parameters.AddWithValue("@id", id.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (id.sales_name != null) { command.Parameters.AddWithValue("@sales_name", id.sales_name); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public List<SALES> GetData()
		{
			List<SALES> items = new List<SALES>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [sales_name] FROM Sales", conn);
					SqlDataReader reader = command.ExecuteReader();
					SALES item = new SALES();
					while(reader.Read())
					{
						item = new SALES();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.sales_name = Convert.ToInt32(reader[1]); }
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

		public List<SALES> GetDataByid(int id)
		{
			List<SALES> items = new List<SALES>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [sales_name] FROM Sales WHERE id = @id", conn);
					command.Parameters.AddWithValue("@id", id);
					SqlDataReader reader = command.ExecuteReader();
					SALES item = new SALES();
					while(reader.Read())
					{
						item = new SALES();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.sales_name = Convert.ToInt32(reader[1]); }
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

		public List<SALES> GetDataBysales_name(int sales_name)
		{
			List<SALES> items = new List<SALES>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [sales_name] FROM Sales WHERE sales_name = @sales_name", conn);
					command.Parameters.AddWithValue("@sales_name", sales_name);
					SqlDataReader reader = command.ExecuteReader();
					SALES item = new SALES();
					while(reader.Read())
					{
						item = new SALES();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.sales_name = Convert.ToInt32(reader[1]); }
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
					SqlCommand command = new SqlCommand("DELETE Sales WHERE id = @id", conn);
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

		public void RemoveBysales_name(int id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE Sales WHERE sales_name = @sales_name", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (id != null) { command.Parameters.AddWithValue("@sales_name", id); } else { command.Parameters.AddWithValue("@sales_name", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public DataTable GetDataTable(List<SALES> sales)
		{
			DataTable dt = new DataTable("SALES");

			DataColumn c1 = new DataColumn("id", typeof(int)); 
			dt.Columns.Add(c1);
			DataColumn c2 = new DataColumn("sales_name", typeof(int)); 
			dt.Columns.Add(c2);

			foreach (SALES v in sales)
			{
				DataRow dr = dt.NewRow();
				if (v.id != null) { dr[0] = v.id; } else { dr[0] = DBNull.Value; }
				if (v.sales_name != null) { dr[1] = v.sales_name; } else { dr[1] = DBNull.Value; }
				dt.Rows.Add(dr);
			}
			dt.AcceptChanges();

			return dt;
		}

		public void AddManyBulk(List<SALES> sales)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();

					DataTable dt = GetDataTable(sales);
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
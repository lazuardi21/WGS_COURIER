using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WGS_COURIER.Models;

namespace WGS_COURIER.Repositories
{
	public partial class COURIERRepository
	{
		private string connString;
		public string Message { get; set; }

		public COURIERRepository(string connectionString)
		{
			connString = connectionString;
		}

		public void Add(COURIER courier)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("INSERT INTO Courier ([id], [courier_name]) VALUES(@id, @courier_name)", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (courier.id != null) { command.Parameters.AddWithValue("@id", courier.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (courier.courier_name != null) { command.Parameters.AddWithValue("@courier_name", courier.courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void AddMany(List<COURIER> courier)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					int pos = 0;
					foreach(COURIER item in courier)
					{
						SqlCommand command = new SqlCommand("INSERT INTO Courier ([id], [courier_name]) VALUES(@id, @courier_name)", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (courier[pos].id != null) { command.Parameters.AddWithValue("@id", courier[pos].id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (courier[pos].courier_name != null) { command.Parameters.AddWithValue("@courier_name", courier[pos].courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
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

		public void Update(COURIER courier)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("UPDATE Courier SET courier_name = @courier_name WHERE id = @id", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (courier.id != null) { command.Parameters.AddWithValue("@id", courier.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
					if (courier.courier_name != null) { command.Parameters.AddWithValue("@courier_name", courier.courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void UpdateMany(List<COURIER> couriers)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					foreach(COURIER item in couriers)
					{
						SqlCommand command = new SqlCommand("UPDATE Courier SET courier_name = @courier_name WHERE id = @id", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (item.id != null) { command.Parameters.AddWithValue("@id", item.id); } else { command.Parameters.AddWithValue("@id", DBNull.Value); } 
						if (item.courier_name != null) { command.Parameters.AddWithValue("@courier_name", item.courier_name); } else { command.Parameters.AddWithValue("@courier_name", DBNull.Value); } 
						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void Remove(COURIER id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE Courier WHERE id = @id", conn);
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

		public List<COURIER> GetData()
		{
			List<COURIER> items = new List<COURIER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [courier_name] FROM Courier", conn);
					SqlDataReader reader = command.ExecuteReader();
					COURIER item = new COURIER();
					while(reader.Read())
					{
						item = new COURIER();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.courier_name = Convert.ToInt32(reader[1]); }
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

		public List<COURIER> GetDataByid(int id)
		{
			List<COURIER> items = new List<COURIER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [courier_name] FROM Courier WHERE id = @id", conn);
					command.Parameters.AddWithValue("@id", id);
					SqlDataReader reader = command.ExecuteReader();
					COURIER item = new COURIER();
					while(reader.Read())
					{
						item = new COURIER();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.courier_name = Convert.ToInt32(reader[1]); }
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
					SqlCommand command = new SqlCommand("DELETE Courier WHERE id = @id", conn);
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

		public DataTable GetDataTable(List<COURIER> courier)
		{
			DataTable dt = new DataTable("COURIER");

			DataColumn c1 = new DataColumn("id", typeof(int)); 
			dt.Columns.Add(c1);
			DataColumn c2 = new DataColumn("courier_name", typeof(int)); c2.AllowDBNull = true;
			dt.Columns.Add(c2);

			foreach (COURIER v in courier)
			{
				DataRow dr = dt.NewRow();
				if (v.id != null) { dr[0] = v.id; } else { dr[0] = DBNull.Value; }
				if (v.courier_name != null) { dr[1] = v.courier_name; } else { dr[1] = DBNull.Value; }
				dt.Rows.Add(dr);
			}
			dt.AcceptChanges();

			return dt;
		}

		public void AddManyBulk(List<COURIER> courier)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();

					DataTable dt = GetDataTable(courier);
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
using System;
using System.Data;
using System.Data.SqlClient;

namespace DapperTutorial.Infrastructure.Data
{
	public class DapperDbContext
	{
		IDbConnection dbConnection;

		public DapperDbContext()
		{
			dbConnection = new SqlConnection("");
		}

		public IDbConnection GetConnection()
        {
			return dbConnection;

		}
	}
}

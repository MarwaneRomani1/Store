using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Store.DataNameSpace.DatabaseConnection
{
    internal class SqlServerConnection
    {
        private static SqlConnection connection = null;
        private SqlServerConnection()
        {
        }

        public static SqlConnection connect(String url)
        {

            if (connection != null)
                return connection;

            connection = new SqlConnection(url);
            return connection;

        }
    }
}

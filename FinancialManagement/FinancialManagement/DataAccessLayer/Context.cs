using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FinancialManagement.DataAccessLayer
{
    public static class Context
    {
        private static SqlConnection database = new SqlConnection(@"Data Source=KEMAL13\SQLEXPRESS;Initial Catalog=FinancieDb;Integrated Security=True");
        public static SqlConnection db()
        {
            return database;
        }
    }
}

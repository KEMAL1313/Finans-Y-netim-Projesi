using FinancialManagement.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagement.Process
{
    public class CityProcess
    {
        public static DataTable GetCity()
        {   
            string query = "select Id,[Name],[Location],IsStatus from City where IsDelete = 0";
            SqlCommand getCity = new SqlCommand(query, DataAccessLayer.Context.db());
            SqlDataAdapter cityAdapter = new SqlDataAdapter(getCity);
            DataTable dt = new DataTable();
            cityAdapter.Fill(dt);
            return dt;
        }
        public static int AddCity(string Name, double Location,bool Status)
        {
            Context.db().Open();

            SqlCommand addCity = new SqlCommand("AddCity", DataAccessLayer.Context.db());
            addCity.CommandType = CommandType.StoredProcedure;
            addCity.Parameters.Add("Name",SqlDbType.NVarChar,150).Value = Name;
            addCity.Parameters.Add("Location", SqlDbType.Float).Value = Location;
            addCity.Parameters.Add("IsStatus", SqlDbType.Bit).Value = Status;
            var ReturnValue = addCity.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            addCity.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int DeleteCity(int Id)
        {

            Context.db().Open();

            SqlCommand deleteCity = new SqlCommand("DeleteCity", DataAccessLayer.Context.db());
            deleteCity.CommandType = CommandType.StoredProcedure;
            deleteCity.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            var ReturnValue = deleteCity.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            deleteCity.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int EditCity(int Id,string Name, double Location, bool Status)
        {
            Context.db().Close();
            SqlCommand editCity = new SqlCommand("EditCity", DataAccessLayer.Context.db());
            editCity.CommandType = CommandType.StoredProcedure;
            editCity.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            editCity.Parameters.Add("Name", SqlDbType.NVarChar, 150).Value = Name;
            editCity.Parameters.Add("Location", SqlDbType.Float).Value = Location;
            editCity.Parameters.Add("IsStatus", SqlDbType.Bit).Value = Status;
            var ReturnValue = editCity.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            editCity.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
    }
}

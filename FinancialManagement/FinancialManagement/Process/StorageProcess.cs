using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagement.DataAccessLayer;

namespace FinancialManagement.Process
{
    public static class StorageProcess
    {
        public static DataTable GetStorage()
        {
            string query = "select Storage.Id,Storage.[Name],City.Name as 'City',Storage.Capacity,Storage.MaxCapacity,Storage.IsStatus from Storage" +
                " inner join City" +
                " on(Storage.CityId = City.Id)" +
                " where Storage.IsDelete = 0";
            SqlCommand getStorage = new SqlCommand(query, DataAccessLayer.Context.db());
            SqlDataAdapter storageAdapter = new SqlDataAdapter(getStorage);
            DataTable dt = new DataTable();
            storageAdapter.Fill(dt);
            return dt;
        }
        public static int AddStorage(string Name, int cityId, double capacity, double mCapacity, bool Status)
        {
            Context.db().Open();
            SqlCommand addCity = new SqlCommand("AddStorage", DataAccessLayer.Context.db());
            addCity.CommandType = CommandType.StoredProcedure;
            addCity.Parameters.Add("Name", SqlDbType.NVarChar, 150).Value = Name;
            addCity.Parameters.Add("CityId", SqlDbType.Int).Value = cityId;
            addCity.Parameters.Add("Capacity", SqlDbType.Float).Value = capacity;
            addCity.Parameters.Add("MaxCapacity", SqlDbType.Float).Value = mCapacity;
            addCity.Parameters.Add("IsStatus", SqlDbType.Bit).Value = Status;
            var ReturnValue = addCity.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            addCity.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int DeleteStorage(int Id)
        {
            Context.db().Open();
            SqlCommand deleteStorage = new SqlCommand("DeleteStorage", DataAccessLayer.Context.db());
            deleteStorage.CommandType = CommandType.StoredProcedure;
            deleteStorage.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            var ReturnValue = deleteStorage.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            deleteStorage.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int EditStorage(string Name, int cityId, double capacity, double mCapacity, bool Status, int Id)
        {
            Context.db().Open();
            SqlCommand addCity = new SqlCommand("EditStorage", DataAccessLayer.Context.db());
            addCity.CommandType = CommandType.StoredProcedure;
            addCity.Parameters.Add("Name", SqlDbType.NVarChar, 150).Value = Name;
            addCity.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            addCity.Parameters.Add("CityId", SqlDbType.Int).Value = cityId;
            addCity.Parameters.Add("Capacity", SqlDbType.Float).Value = capacity;
            addCity.Parameters.Add("MaxCapacity", SqlDbType.Float).Value = mCapacity;
            addCity.Parameters.Add("IsStatus", SqlDbType.Bit).Value = Status;
            var ReturnValue = addCity.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            addCity.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static DataTable FillComboBox(){
            string query = "select Id,[Name] from City where IsDelete =0 and IsStatus = 1";
            SqlCommand fillCb = new SqlCommand(query, DataAccessLayer.Context.db());
            SqlDataAdapter fillCbAdapter = new SqlDataAdapter(fillCb);
            DataTable dt = new DataTable();
            fillCbAdapter.Fill(dt);
            return dt;
        }
        public static DataTable FullnessStorage()
        {
            string query = "select * from [Storage Fullness]";
            SqlCommand storageFullness = new SqlCommand(query, DataAccessLayer.Context.db());
            SqlDataAdapter storageFullnessCbAdapter = new SqlDataAdapter(storageFullness);
            DataTable dt = new DataTable();
            storageFullnessCbAdapter.Fill(dt);
            return dt;
        }
    }
}

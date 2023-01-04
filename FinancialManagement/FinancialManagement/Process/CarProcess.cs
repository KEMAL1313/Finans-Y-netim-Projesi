using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using FinancialManagement.DataAccessLayer;

namespace FinancialManagement.Process
{
    class CarProcess
    {
        public static DataTable GetCar()
        {
            string query = "select Id,Plate,Brand,Modal,Capacity,IsStatus from Car where IsDelete = 0";
            SqlCommand getCar = new SqlCommand(query, DataAccessLayer.Context.db());
            SqlDataAdapter carAdapter = new SqlDataAdapter(getCar);
            DataTable dt = new DataTable();
            carAdapter.Fill(dt);
            return dt;
        }
        public static int AddCar(string plate, string brand, string modal, bool status, double capacity)
        {
            Context.db().Open();
            SqlCommand addCar = new SqlCommand("AddCar", DataAccessLayer.Context.db());
            addCar.CommandType = CommandType.StoredProcedure;
            addCar.Parameters.Add("Plate", SqlDbType.NVarChar, 11).Value = plate;
            addCar.Parameters.Add("Brand", SqlDbType.NVarChar, 25).Value = brand;
            addCar.Parameters.Add("Modal", SqlDbType.NVarChar, 25).Value = modal;
            addCar.Parameters.Add("Capacity" ,SqlDbType.Float).Value = capacity;
            addCar.Parameters.Add("IsStatus", SqlDbType.Bit).Value = status;
            var ReturnValue = addCar.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            addCar.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int DeleteCar(int Id)
        {
            Context.db().Open();
            SqlCommand deleteCar = new SqlCommand("DeleteCar", DataAccessLayer.Context.db());
            deleteCar.CommandType = CommandType.StoredProcedure;
            deleteCar.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            var ReturnValue = deleteCar.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            deleteCar.ExecuteNonQuery();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int EditCar(string plate, string brand, string modal, bool status, double capacity, int Id)
        {
            SqlCommand editdCar = new SqlCommand("EditCar", DataAccessLayer.Context.db());
            editdCar.CommandType = CommandType.StoredProcedure;
            editdCar.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            editdCar.Parameters.Add("Plate", SqlDbType.NVarChar, 11).Value = plate;
            editdCar.Parameters.Add("Brand", SqlDbType.NVarChar, 25).Value = brand;
            editdCar.Parameters.Add("Modal", SqlDbType.NVarChar, 25).Value = modal;
            editdCar.Parameters.Add("Capacity", SqlDbType.Float).Value = capacity;
            editdCar.Parameters.Add("IsStatus", SqlDbType.Bit).Value = status;
            var ReturnValue = editdCar.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            editdCar.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
    }
}

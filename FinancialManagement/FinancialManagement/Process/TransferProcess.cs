using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagement.View.Process.Transfer;
using FinancialManagement.DataAccessLayer;

namespace FinancialManagement.Process
{
    public class TransferProcess
    {
        public static DataTable GetTransfer()
        {
            string query = "select Id,FirstStorageId,SecondStorageId,CarId,PersonalId,CargoSpace,IsStatus from Transfer where IsDelete = 0";
            SqlCommand getCar = new SqlCommand(query, DataAccessLayer.Context.db());
            SqlDataAdapter carAdapter = new SqlDataAdapter(getCar);
            DataTable dt = new DataTable();
            carAdapter.Fill(dt);
            return dt;
        }
        public static int AddTransfer(int outStorage, int entranceStorage, int cargoSpace, int personalId, int carId)
        {
            Context.db().Open();
            SqlCommand addTransfer = new SqlCommand("AddTransfer", DataAccessLayer.Context.db());
            addTransfer.CommandType = CommandType.StoredProcedure;
            addTransfer.Parameters.Add("FirstStorageId", SqlDbType.Int).Value = outStorage;
            addTransfer.Parameters.Add("SecondStorageId", SqlDbType.Int).Value = entranceStorage;
            addTransfer.Parameters.Add("CargoSpace", SqlDbType.Int).Value = cargoSpace;
            addTransfer.Parameters.Add("PersonalId", SqlDbType.Int).Value = personalId;
            addTransfer.Parameters.Add("CarId", SqlDbType.Int).Value = carId;
            var ReturnValue = addTransfer.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            addTransfer.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int DeleteTransfer(int Id)
        {
            Context.db().Open();
            SqlCommand deletdTransfer = new SqlCommand("DeleteTransfer", DataAccessLayer.Context.db());
            deletdTransfer.CommandType = CommandType.StoredProcedure;
            deletdTransfer.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            var ReturnValue = deletdTransfer.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            deletdTransfer.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
        public static int EditTransfer(int outStorage, int entranceStorage, int cargoSpace, int personalId, int carId, int Id, bool status)
        {
            Context.db().Open();
            SqlCommand editTransfer = new SqlCommand("EditTransfer", DataAccessLayer.Context.db());
            editTransfer.CommandType = CommandType.StoredProcedure;
            editTransfer.Parameters.Add("Id", SqlDbType.Int).Value = Id;
            editTransfer.Parameters.Add("FirstStorageId", SqlDbType.Int).Value = outStorage;
            editTransfer.Parameters.Add("SecondStorageId", SqlDbType.Int).Value = entranceStorage;
            editTransfer.Parameters.Add("CargoSpace", SqlDbType.Int).Value = cargoSpace;
            editTransfer.Parameters.Add("PersonalId", SqlDbType.Int).Value = personalId;
            editTransfer.Parameters.Add("CarId", SqlDbType.Int).Value = carId;
            editTransfer.Parameters.Add("NewStatus", SqlDbType.Bit).Value = status;
            var ReturnValue = editTransfer.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            editTransfer.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(ReturnValue.Value);
            return result;
        }
    }
}

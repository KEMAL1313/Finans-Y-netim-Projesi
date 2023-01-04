using FinancialManagement.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement.View.AccountingOffice.Statement
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }
        private void Expense_Load(object sender, EventArgs e)
        {
            gider();
        }
        public void gider()
        {
            string sorgu = "select Expense.Amount as ExpenseAmount,Expense.Description, Expense.Date from Expense where IsDelete=0";
            SqlDataAdapter sqlData = new SqlDataAdapter(sorgu, Context.db());
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            expenseDgv.DataSource = dt;
        }
        private void calculatIncomeBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            SqlCommand sqlCommand = new SqlCommand("ExpenseBeetween", Context.db());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("Giris", SqlDbType.Date).Value = dateTimePicker1.Value;
            sqlCommand.Parameters.Add("Cikis", SqlDbType.Date).Value = dateTimePicker2.Value;
            var ReturnValue = sqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Float);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            Context.db().Close();
            double result = Convert.ToDouble(ReturnValue.Value);
            expenseLbl.Text = result.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

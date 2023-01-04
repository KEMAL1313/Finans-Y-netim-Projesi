using FinancialManagement.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialManagement.View.AccountingOffice.Income_Expense
{
    public partial class Edit : Form
    {
        public static int id = 0;
        public Edit()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            incomeTxt.Clear();
            incomeRTB.Clear();
            expenseTxt.Clear();
            expenseRTB.Clear();

        }
        public void gelir()
        {
            string sorgu = "select Income.Id,Income.Amount as IncomeAmount,Income.Description, Income.Date,Income.IsStatus as Status from Income where IsDelete=0";
            SqlDataAdapter sqlData = new SqlDataAdapter(sorgu, Context.db());
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            incomeDgv.DataSource = dt;
            incomeDgv.Columns[0].Visible = false;
        }
        public void gider()
        {
            string sorgu = "select Expense.Id,Expense.Amount as ExpenseAmount,Expense.Description, Expense.Date,Expense.IsStatus as Status from Expense where IsDelete=0";
            SqlDataAdapter sqlData = new SqlDataAdapter(sorgu, Context.db());
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            expenseDgv.DataSource = dt;
            expenseDgv.Columns[0].Visible = false;
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            gelir();
            gider();
        }
        private void incomeDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            incomeTxt.Text = incomeDgv.CurrentRow.Cells[1].Value.ToString();
            incomeDTP.Value = Convert.ToDateTime(incomeDgv.CurrentRow.Cells[3].Value.ToString());
            incomeRTB.Text = incomeDgv.CurrentRow.Cells[2].Value.ToString();
        }
        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            id = Convert.ToInt32(incomeDgv.CurrentRow.Cells[0].Value.ToString());
            SqlCommand sql = new SqlCommand("EditIncome", Context.db());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("Id", SqlDbType.Int).Value = id;
            sql.Parameters.Add("Amount", SqlDbType.Float).Value = incomeTxt.Text;
            sql.Parameters.Add("Date", SqlDbType.Date).Value = incomeDTP.Value;
            sql.Parameters.Add("Description", SqlDbType.Text).Value = incomeRTB.Text;
            var returnValue = sql.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;
            sql.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(returnValue.Value);
            if (result == 1)
            {
                MessageBox.Show("Income Edited Successful");
                gelir();
            }
            else
            {
                MessageBox.Show("Not Found Income");
            }
            Reset();
        }
        private void expenseDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            expenseTxt.Text = expenseDgv.CurrentRow.Cells[1].Value.ToString();
            expenseDTP.Value = Convert.ToDateTime(expenseDgv.CurrentRow.Cells[3].Value.ToString());
            expenseRTB.Text = expenseDgv.CurrentRow.Cells[2].Value.ToString();
        }
        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            id = Convert.ToInt32(expenseDgv.CurrentRow.Cells[0].Value.ToString());
            SqlCommand sql = new SqlCommand("EditExpense", Context.db());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("Id", SqlDbType.Int).Value = id;
            sql.Parameters.Add("Amount", SqlDbType.Float).Value = expenseTxt.Text;
            sql.Parameters.Add("Date", SqlDbType.Date).Value = expenseDTP.Value;
            sql.Parameters.Add("Description", SqlDbType.Text).Value = expenseRTB.Text;
            var returnValue = sql.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;
            sql.ExecuteNonQuery();
            Context.db().Close();
            int result = Convert.ToInt32(returnValue.Value);
            if (result == 1)
            {
                MessageBox.Show("Expense Edited Successful");
                gider();
            }
            else
            {
                MessageBox.Show("Not Found Expense");
            }
            Reset();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

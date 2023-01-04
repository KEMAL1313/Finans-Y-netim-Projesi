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
    public partial class Add : Form
    {
        public Add()
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
        
        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            if (!String.IsNullOrWhiteSpace(incomeTxt.Text) && !String.IsNullOrWhiteSpace(incomeRTB.Text))
            {
                SqlCommand sqlCommand = new SqlCommand("AddIncome", Context.db());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("Amount", SqlDbType.Float).Value = Convert.ToInt32(incomeTxt.Text);
                sqlCommand.Parameters.Add("Date", SqlDbType.Date).Value = incomeDTP.Value;
                sqlCommand.Parameters.Add("Description", SqlDbType.Text).Value = incomeRTB.Text;
                var ReturnValue = sqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                sqlCommand.ExecuteNonQuery();
                Context.db().Close();
                int result = Convert.ToInt32(ReturnValue.Value);
                if (result == 1)
                {
                    MessageBox.Show("Income Added Successfull", "Income Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                }
                else
                {
                    MessageBox.Show("An error occurred while adding!", "Income Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
              
            }
            else
            {
                MessageBox.Show("Değerler Boş Geçilemez");
            }
            Reset();
        }
        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            if (!String.IsNullOrWhiteSpace(expenseTxt.Text) && !String.IsNullOrWhiteSpace(expenseRTB.Text))
            {
                SqlCommand sqlCommand = new SqlCommand("AddExpense", Context.db());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("Amount", SqlDbType.Float).Value = Convert.ToInt32(expenseTxt.Text);
                sqlCommand.Parameters.Add("Date", SqlDbType.Date).Value = expenseDTP.Value;
                sqlCommand.Parameters.Add("Description", SqlDbType.Text).Value = expenseRTB.Text;
                var ReturnValue = sqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                sqlCommand.ExecuteNonQuery();
                Context.db().Close();
                int result = Convert.ToInt32(ReturnValue.Value);
                if (result == 1)
                {
                    MessageBox.Show("Expense Added Successfull", "Expense Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while adding!", "Expense Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Değerler Boş Geçilemez");
            }
            Reset();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

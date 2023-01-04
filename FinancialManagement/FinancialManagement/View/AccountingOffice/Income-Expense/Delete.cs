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

namespace FinancialManagement.View.AccountingOffice.Income_Expense
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        public static int id1 = 0;
        public static int id2 = 0;
        public void gelir()
        {
            string sorgu = "select Income.Id,Income.Amount as IncomeAmount,Income.Description, Income.Date,Income.IsStatus as Status from Income where IsDelete=0";
            SqlDataAdapter sqlData = new SqlDataAdapter(sorgu, Context.db());
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            IncomeDgw.DataSource = dt;
        }
        public void gider()
        {
            string sorgu = "select Expense.Id,Expense.Amount as ExpenseAmount,Expense.Description, Expense.Date,Expense.IsStatus as Status from Expense where IsDelete=0";
            SqlDataAdapter sqlData = new SqlDataAdapter(sorgu, Context.db());
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            expenseDgw.DataSource = dt;
        }
        private void Delete_Load(object sender, EventArgs e)
        {
            gelir();
            gider();
        }
        private void IncomeDgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = IncomeDgw.CurrentRow.Cells[0].Value.ToString();
        }
        private void incomeDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialog = new DialogResult();

            deleteDialog = MessageBox.Show("Delete Income?",
                                        "Delete Income",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            Context.db().Open();
            if (deleteDialog == DialogResult.Yes)
            {
                SqlCommand deleteControl = new SqlCommand("deleteIncome", Context.db());
                deleteControl.CommandType = CommandType.StoredProcedure;
                deleteControl.Parameters.Add("Id", SqlDbType.Int).Value = textBox1.Text;
                var returnValue = deleteControl.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                deleteControl.ExecuteNonQuery();
                Context.db().Close();
                int result = Convert.ToInt32(returnValue.Value);
                if (result == 1)
                {
                    MessageBox.Show("Income Deletion Successful",
                               "Delete Income",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    gelir();
                }
                else
                {
                    MessageBox.Show("Income Not Found",
                               "Delete Income",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Income Deletion Canceled",
                                "Delete Income",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            textBox1.Clear();
        }
        private void expenseDgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = expenseDgw.CurrentRow.Cells[0].Value.ToString();
        }
        private void expenseDeleteBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            DialogResult deleteDialog = new DialogResult();
            deleteDialog = MessageBox.Show("Delete Expense?",
                                        "Delete Expense",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (deleteDialog == DialogResult.Yes)
            {
                SqlCommand deleteControl = new SqlCommand("deleteExpense", Context.db());
                deleteControl.CommandType = CommandType.StoredProcedure;
                deleteControl.Parameters.Add("Id", SqlDbType.Int).Value = textBox2.Text;
                var returnValue = deleteControl.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                deleteControl.ExecuteNonQuery();
                Context.db().Close();
                int result = Convert.ToInt32(returnValue.Value);
                if (result == 1)
                {
                    MessageBox.Show("Expense Deletion Successful",
                               "Delete Expense",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    gider();
                }
                else
                {
                    MessageBox.Show("Expense Not Found",
                               "Delete Expense",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Expense Deletion Canceled",
                                "Delete Expense",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            textBox2.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

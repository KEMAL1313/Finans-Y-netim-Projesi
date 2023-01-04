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

namespace FinancialManagement.View.HR
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            Context.db().Open();
            string sorgu = "select * from Employee where IsDelete=0";
            SqlCommand sql = new SqlCommand(sorgu, Context.db());
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dgw.DataSource = table;
            Context.db().Close();
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            GetData();
            UpdateEmployeeIdTxt.Enabled = false;
            checkBox2.Visible = false;
            Status.Visible = false;
        }
        public void getClear()
        {
            UpdateEmployeeNametxt.Clear();
            UpdateEmployeeIdTxt.Clear();
            UpdateEmployeeEmailTxt.Clear();
            UpdateEmployeePhoneTxt.Clear();
            UpdateEmployeeRoleTxt.Clear();
            UpdateEmployeeSalaryTxt.Clear();
            UpdateEmployeeSurnameTxt.Clear();

        }
        private void dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateEmployeeNametxt.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            UpdateEmployeeSurnameTxt.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            UpdateEmployeeEmailTxt.Text = dgw.CurrentRow.Cells[5].Value.ToString();
            UpdateEmployeePhoneTxt.Text = dgw.CurrentRow.Cells[6].Value.ToString();
            UpdateEmployeeIdTxt.Text = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value).ToString();
            UpdateEmployeeRoleTxt.Text = Convert.ToInt32(dgw.CurrentRow.Cells[3].Value).ToString();
            UpdateEmployeeSalaryTxt.Text = Convert.ToDouble(dgw.CurrentRow.Cells[4].Value).ToString();
            Status.Checked = Convert.ToBoolean(dgw.CurrentRow.Cells[7].Value);
            checkBox2.Checked = Convert.ToBoolean(dgw.CurrentRow.Cells[8].Value);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            SqlCommand sqlCommand = new SqlCommand("EditEmployee", Context.db());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("Id", SqlDbType.Int).Value = Convert.ToInt32(UpdateEmployeeIdTxt.Text);
            sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar, 50).Value = UpdateEmployeeNametxt.Text;
            sqlCommand.Parameters.Add("Surname", SqlDbType.NVarChar, 50).Value = UpdateEmployeeSurnameTxt.Text;
            sqlCommand.Parameters.Add("Phone", SqlDbType.NVarChar, 14).Value = UpdateEmployeePhoneTxt.Text;
            sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = UpdateEmployeeEmailTxt.Text;
            sqlCommand.Parameters.Add("RoleId", SqlDbType.Int).Value = Convert.ToInt32(UpdateEmployeeRoleTxt.Text);
            sqlCommand.Parameters.Add("Salary", SqlDbType.Float).Value = UpdateEmployeeSalaryTxt.Text;
            sqlCommand.Parameters.Add("IsStatus", SqlDbType.Bit).Value = Status.Checked;
            sqlCommand.Parameters.Add("IsDelete", SqlDbType.Bit).Value = checkBox2.Checked;
            var returnValue = sqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = Convert.ToInt32(returnValue.Value);
            if (result == 1)
            {
                MessageBox.Show("Employee Edited Successful");
                getClear();
            }
            else
            {
                MessageBox.Show("Not Found Employee");
            }
            Context.db().Close();
            GetData();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialog = new DialogResult();
            deleteDialog = MessageBox.Show("Delete Customer?",
                                        "Delete Customer",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (deleteDialog == DialogResult.Yes)
            {
                Context.db().Open();
                SqlCommand deleteControl = new SqlCommand("DeleteEmployee", Context.db());
                deleteControl.CommandType = CommandType.StoredProcedure;
                deleteControl.Parameters.Add("Id", SqlDbType.Int).Value = Convert.ToInt32(UpdateEmployeeIdTxt.Text);
                var returnValue = deleteControl.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                deleteControl.ExecuteNonQuery();
                int result = Convert.ToInt32(returnValue.Value);
                Context.db().Close();
                if (result == 1)
                {
                    MessageBox.Show("Customer Deletion Successful",
                               "Delete Customer",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    GetData();
                    getClear();
                }
                else
                {
                    MessageBox.Show("Customer Not Found",
                               "Delete Customer",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Customer Deletion Canceled",
                                "Delete Customer",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

}


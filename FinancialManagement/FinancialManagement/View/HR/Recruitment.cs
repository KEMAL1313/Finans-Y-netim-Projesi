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
    public partial class Recruitment : Form
    {
        public Recruitment()
        {
            InitializeComponent();
        }
        private void Recruitment_Load(object sender, EventArgs e)
        {
            GetData();
            addEmployeeIdTxt.Enabled = false;
            addEmployeeEmailTxt.Enabled = false;
            addEmployeeNametxt.Enabled = false;
            addEmployeePhoneTxt.Enabled = false;
            addEmployeeSurnameTxt.Enabled = false;
            checkBox2.Visible = false;
            Status.Visible = false;
        }
        public void getClear()
        {
            addEmployeeNametxt.Clear();
            addEmployeeIdTxt.Clear();
            addEmployeeEmailTxt.Clear();
            addEmployeePhoneTxt.Clear();
            addEmployeeRoleTxt.Clear();
            addEmployeeSalaryTxt.Clear();
            addEmployeeSurnameTxt.Clear();
        }
        public void GetData()
        {
            Context.db().Open();
            string sorgu = "select * from CV where IsDelete=0";
            SqlCommand sql = new SqlCommand(sorgu, Context.db());
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dgw.DataSource = table;
            Context.db().Close();
        }
        private void dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addEmployeeNametxt.Text = dgw.CurrentRow.Cells[1].Value.ToString();
            addEmployeeSurnameTxt.Text = dgw.CurrentRow.Cells[2].Value.ToString();
            addEmployeeEmailTxt.Text = dgw.CurrentRow.Cells[5].Value.ToString();
            addEmployeePhoneTxt.Text = dgw.CurrentRow.Cells[4].Value.ToString();
            addEmployeeIdTxt.Text = Convert.ToInt32(dgw.CurrentRow.Cells[0].Value).ToString();
            Status.Checked = Convert.ToBoolean(dgw.CurrentRow.Cells[11].Value);
            checkBox2.Checked = Convert.ToBoolean(dgw.CurrentRow.Cells[12].Value);
        }
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            SqlCommand sqlCommand = new SqlCommand("AddEmployee", Context.db());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar, 50).Value = addEmployeeNametxt.Text;
            sqlCommand.Parameters.Add("Surname", SqlDbType.NVarChar, 50).Value = addEmployeeSurnameTxt.Text;
            sqlCommand.Parameters.Add("Phone", SqlDbType.NVarChar, 14).Value = addEmployeePhoneTxt.Text;
            sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = addEmployeeEmailTxt.Text;
            sqlCommand.Parameters.Add("RoleId", SqlDbType.Int).Value = Convert.ToInt32(addEmployeeRoleTxt.Text);
            sqlCommand.Parameters.Add("Salary", SqlDbType.Float).Value = addEmployeeSalaryTxt.Text;
            sqlCommand.Parameters.Add("IsStatus", SqlDbType.Bit).Value = Status.Checked;
            sqlCommand.Parameters.Add("IsDelete", SqlDbType.Bit).Value = checkBox2.Checked;
            var ReturnValue = sqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = Convert.ToInt32(ReturnValue.Value);
            Context.db().Close();
            if (result == 1)
            {
                MessageBox.Show("İşe Alım Başarılı");
                Context.db().Open();
                SqlCommand sqlCommand1 = new SqlCommand("EditCv", Context.db());
                sqlCommand1.CommandType = CommandType.StoredProcedure;
                sqlCommand1.Parameters.Add("Id", SqlDbType.Int).Value = Convert.ToInt32(addEmployeeIdTxt.Text);
                sqlCommand1.Parameters.Add("IsDelete", SqlDbType.Bit).Value = 1;
                var returnValue = sqlCommand1.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                sqlCommand1.ExecuteNonQuery();
                Context.db().Close();
                GetData();
                getClear();
            }
            else
            {
                MessageBox.Show("İşe Alım Başarısız");
            }
        }
        private void deleteCVBtn_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialog = new DialogResult();

            deleteDialog = MessageBox.Show("Delete Cv?",
                                        "Delete Cv",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (deleteDialog == DialogResult.Yes)
            {
                Context.db().Open();
                SqlCommand deleteControl = new SqlCommand("DeleteCv", Context.db());
                deleteControl.CommandType = CommandType.StoredProcedure;
                deleteControl.Parameters.Add("Id", SqlDbType.Int).Value = Convert.ToInt32(addEmployeeIdTxt.Text);
                var returnValue = deleteControl.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                deleteControl.ExecuteNonQuery();
                int result = Convert.ToInt32(returnValue.Value);
                Context.db().Close();
                if (result == 1)
                {
                    MessageBox.Show("Cv Deletion Successful",
                               "Delete Cv",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    GetData();
                    getClear();
                }
                else
                {
                    MessageBox.Show("Cv Not Found",
                               "Delete Cv",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cv Deletion Canceled",
                                "Delete Cv",
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

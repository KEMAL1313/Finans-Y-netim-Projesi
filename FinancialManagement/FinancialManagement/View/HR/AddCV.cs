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
    public partial class AddCV : Form
    {
        public AddCV()
        {
            InitializeComponent();
        }
        public void getClear()
        {
            addnametxt.Clear();
            addsurnametxt.Clear();
            addagetxt.Clear();
            addphonetxt.Clear();
            addemailtxt.Clear();
            addExperienceRich.Clear();
            addEducationRich.Clear();
            addCertificateRich.Clear();
            addAddressRich.Clear();
            addskillsRich.Clear();

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();

            SqlCommand sqlCommand = new SqlCommand("AddCv", Context.db());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar, 50).Value = addnametxt.Text;
            sqlCommand.Parameters.Add("Surname", SqlDbType.NVarChar, 50).Value = addsurnametxt.Text;
            sqlCommand.Parameters.Add("Age", SqlDbType.Int).Value = addagetxt.Text;
            sqlCommand.Parameters.Add("Phone", SqlDbType.NVarChar, 14).Value = addphonetxt.Text;
            sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = addemailtxt.Text;
            sqlCommand.Parameters.Add("Experience", SqlDbType.Text).Value = addExperienceRich.Text;
            sqlCommand.Parameters.Add("Education", SqlDbType.Text).Value = addEducationRich.Text;
            sqlCommand.Parameters.Add("Certificate", SqlDbType.Text).Value = addCertificateRich.Text;
            sqlCommand.Parameters.Add("Address", SqlDbType.Text).Value = addAddressRich.Text;
            sqlCommand.Parameters.Add("Skills", SqlDbType.Text).Value = addskillsRich.Text;
            sqlCommand.Parameters.Add("IsStatus", SqlDbType.Bit).Value = 1;
            sqlCommand.Parameters.Add("IsDelete", SqlDbType.Bit).Value = 0;
            var ReturnValue = sqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
            ReturnValue.Direction = ParameterDirection.ReturnValue;
            sqlCommand.ExecuteNonQuery();
            int result = Convert.ToInt32(ReturnValue.Value);
            Context.db().Close();
            if (result == 1)
            {
                MessageBox.Show("Cv Ekleme Başarılı");
                getClear();
            }
            else
            {
                MessageBox.Show("Cv Ekleme Başarısız");
            }
        }
        private void AddCV_Load(object sender, EventArgs e)
        {

            addStatuscb.Visible = false;
            addDeletecb.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

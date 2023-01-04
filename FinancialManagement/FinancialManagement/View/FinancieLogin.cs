using FinancialManagement.DataAccessLayer;
using FinancialManagement.View;
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

namespace FinancialManagement
{
    public partial class FinancieLogin : Form
    {
        public FinancieLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Context.db().Open();
            SqlCommand loginControl = new SqlCommand("UserLogin",Context.db());
            loginControl.CommandType = CommandType.StoredProcedure;
            loginControl.Parameters.Add("@UserName",SqlDbType.NVarChar,150).Value = userNameTxt.Text;
            loginControl.Parameters.Add("@Password", SqlDbType.NVarChar, 150).Value = passTxt.Text;

            var returnValue = loginControl.Parameters.Add("@LoginControl",SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;
            loginControl.ExecuteNonQuery();
            var loginResult = returnValue.Value;
            if (Convert.ToInt32(loginResult) != 0)
            {
                MessageBox.Show("Welcome");
                userNameTxt.Clear();
                passTxt.Clear();
                Context.db().Close();
                FinancieMenu financieMenu = new FinancieMenu();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Login failed");
                userNameTxt.Clear();
                passTxt.Clear();
                Context.db().Close();
            }
            
        }

        private void FinancieLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

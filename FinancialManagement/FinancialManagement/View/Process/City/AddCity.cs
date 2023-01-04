using FinancialManagement.Model;
using FinancialManagement.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement.View.Services.City
{
    public partial class AddCity : Form
    {
        int addSucces = 0;
        string error = "";
        public AddCity()
        {
            InitializeComponent();
        }
        private void AddCity_Load(object sender, EventArgs e)
        {
            cityDGV.DataSource = CityProcess.GetCity();
            cityDGV.Columns[0].Visible = false;
        }
        public void Reset()
        {
            this.cityDGV.DataSource = CityProcess.GetCity();
            nameTxt.Text = "";
            locationNmrc.Value = 0;
            statusCB.Checked = false;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text !=""&&locationNmrc.Value>0)
            {
                addSucces = CityProcess.AddCity(nameTxt.Text, Convert.ToDouble(locationNmrc.Value), statusCB.Checked);
                error = ((CityEnum)addSucces).ToString();
                MessageBox.Show(error);

            }
            else
            {
                error = "Please Fill Every Area.";
                MessageBox.Show(error);
            }
            Reset();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

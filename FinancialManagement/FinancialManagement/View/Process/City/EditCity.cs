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
    public partial class EditCity : Form
    {
        int cityId = 0;
        int editControl;
        string error = "";
        public EditCity()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            this.cityDGV.DataSource = CityProcess.GetCity();
            nameTxt.Text = "";
            locationNmrc.Value = 0;
            statusCB.Checked = false;
            cityId = 0;
        }
        private void EditCity_Load(object sender, EventArgs e)
        {
            cityDGV.DataSource = CityProcess.GetCity();
            cityDGV.Columns[0].Visible = false;
        }
        private void cityDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cityId = Convert.ToInt32(cityDGV.CurrentRow.Cells[0].Value);
            nameTxt.Text = cityDGV.CurrentRow.Cells[1].Value.ToString();
            locationNmrc.Value = Convert.ToInt32(cityDGV.CurrentRow.Cells[2].Value);
            statusCB.Checked = Convert.ToBoolean(cityDGV.CurrentRow.Cells[3].Value);
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (cityId != 0)
            {
                editControl = CityProcess.EditCity(cityId, nameTxt.Text, Convert.ToDouble(locationNmrc.Value), statusCB.Checked);
                error = ((CityEnum)editControl).ToString();
                MessageBox.Show(error);
            }
            else
            {
                error = "Please Select City";
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

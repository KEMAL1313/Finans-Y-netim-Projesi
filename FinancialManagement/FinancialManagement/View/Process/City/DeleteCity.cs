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
    public partial class DeleteCity : Form
    {
        int cityId = 0;
        int deleteControl = 0;
        string error = "Please Select City";
        public DeleteCity()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            this. cityDGV.DataSource = CityProcess.GetCity();
            nameTxt.Text = "";
            locationNmrc.Value = 0;
            statusCB.Checked = false;
            cityId = 0;
        }
        private void DeleteCity_Load(object sender, EventArgs e)
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
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (cityId != 0)
            {
                deleteControl = CityProcess.DeleteCity(cityId);
                error = ((CityEnum)deleteControl).ToString();
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

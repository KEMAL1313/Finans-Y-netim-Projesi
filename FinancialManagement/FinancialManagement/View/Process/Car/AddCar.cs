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

namespace FinancialManagement.View.Services.Car
{
    public partial class AddCar : Form
    {
        string error;
        int addControl;
        public AddCar()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            plateTxt.Text = "";
            brandTxt.Text = "";
            modelTxt.Text = "";
            statusCb.Checked = false;
            carDGV.DataSource = CarProcess.GetCar();
        }
        private void AddCar_Load(object sender, EventArgs e)
        {
            Reset();
            carDGV.Columns[0].Visible = false;
        } 
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (plateTxt.Text!= "" && brandTxt.Text != ""&& modelTxt.Text != "" && capacityNmrc.Value != 0)
            {
                addControl = CarProcess.AddCar(plateTxt.Text, brandTxt.Text, modelTxt.Text,statusCb.Checked,Convert.ToDouble(capacityNmrc.Value));
                error = ((CarEnum)addControl).ToString();
                MessageBox.Show(error);
            }
            else
            {
                error = "Please Fill Every Area";
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

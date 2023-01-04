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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinancialManagement.View.Services.Car
{
    public partial class DeleteCar : Form
    {
        string error;
        int deleteControl;
        int carId;
        public DeleteCar()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            plateTxt.Text = "";
            brandTxt.Text = "";
            modelTxt.Text = "";
            statusCb.Checked = false;
            carId = 0;
            carDGV.DataSource = CarProcess.GetCar();
        }
        private void DeleteCar_Load(object sender, EventArgs e)
        {
            Reset();
            carDGV.Columns[0].Visible = false;
        }

        private void carDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            carId = Convert.ToInt32(carDGV.CurrentRow.Cells[0].Value);
            plateTxt.Text = carDGV.CurrentRow.Cells[1].Value.ToString();
            brandTxt.Text = carDGV.CurrentRow.Cells[2].Value.ToString();
            modelTxt.Text = carDGV.CurrentRow.Cells[3].Value.ToString();
            capacityNmrc.Value = Convert.ToInt32(carDGV.CurrentRow.Cells[4].Value);
            statusCb.Checked = Convert.ToBoolean(carDGV.CurrentRow.Cells[5].Value);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (plateTxt.Text != "" && brandTxt.Text != "" && modelTxt.Text != "" && capacityNmrc.Value != 0)
            {
                deleteControl = CarProcess.DeleteCar(carId);
                error = ((CarEnum)deleteControl).ToString();
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

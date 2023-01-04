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

namespace FinancialManagement.View.Services.Storage
{
    public partial class EditStorage : Form
    {
        string error;
        int storageId;
        int editCotnrol;
        public EditStorage()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            cityCmb.SelectedIndex = -1;
            nameTxt.Text = "";
            capacityNmrc.Value = 0;
            mCapacityNmrc.Value = 0;
            storageId = 0;
            statusCb.Checked = false;
            storageDGV.DataSource = StorageProcess.GetStorage();
        }
        private void EditStorage_Load(object sender, EventArgs e)
        {
            cityCmb.DataSource = null;
            storageDGV.DataSource = StorageProcess.GetStorage();
            storageDGV.Columns[0].Visible = false;
            cityCmb.DataSource = StorageProcess.FillComboBox();
            cityCmb.SelectedIndex = 0;
            cityCmb.ValueMember = "Id";
            cityCmb.DisplayMember = "Name";
        }
        private void storageDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            storageId = Convert.ToInt32(storageDGV.CurrentRow.Cells[0].Value);
            nameTxt.Text = storageDGV.CurrentRow.Cells[1].Value.ToString();
            capacityNmrc.Value = Convert.ToInt32(storageDGV.CurrentRow.Cells[3].Value);
            mCapacityNmrc.Value = Convert.ToInt32(storageDGV.CurrentRow.Cells[4].Value);
            statusCb.Checked = Convert.ToBoolean(storageDGV.CurrentRow.Cells[5].Value);
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "" && cityCmb.SelectedIndex != -1 && capacityNmrc.Value != 0 && mCapacityNmrc.Value != 0)
            {
                editCotnrol = StorageProcess.EditStorage(nameTxt.Text, Convert.ToInt32(cityCmb.SelectedValue), Convert.ToDouble(capacityNmrc.Value), Convert.ToDouble(mCapacityNmrc.Value), statusCb.Checked,storageId);
                error = ((StorageEnum)editCotnrol).ToString();
                MessageBox.Show(error);
            }
            else
            {
                error = "Please Select Storage and Fill Every Area";
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

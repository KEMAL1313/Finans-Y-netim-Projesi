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
    public partial class DeleteStorage : Form
    {
        int storageId = 0;
        int deleteControl;
        string error;
        public DeleteStorage()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            nameTxt.Text = "";
            cityCmb.Items.Clear();
            capacityNmrc.Value = 0;
            mCapacityNmrc.Value = 0;
            statusCb.Checked = false;
            storageId = 0;
            this.storageDGV.DataSource = StorageProcess.GetStorage();
        }
        private void DeleteStorage_Load(object sender, EventArgs e)
        {
            storageDGV.DataSource = StorageProcess.GetStorage();
            storageDGV.Columns[0].Visible = false;
        }
        private void storageDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            storageId = Convert.ToInt32(storageDGV.CurrentRow.Cells[0].Value);
            nameTxt.Text = storageDGV.CurrentRow.Cells[1].Value.ToString();
            cityCmb.Items.Clear();
            cityCmb.Items.Add(storageDGV.CurrentRow.Cells[2].Value.ToString());
            cityCmb.SelectedIndex = 0;
            capacityNmrc.Value = Convert.ToInt32(storageDGV.CurrentRow.Cells[3].Value);
            mCapacityNmrc.Value = Convert.ToInt32(storageDGV.CurrentRow.Cells[4].Value);
            statusCb.Checked = Convert.ToBoolean(storageDGV.CurrentRow.Cells[5].Value);
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (storageId !=0)
            {
                deleteControl = StorageProcess.DeleteStorage(storageId);
                error = ((StorageEnum)deleteControl).ToString();
                MessageBox.Show(error);
            }
            else
            {
                error = "Please Choose Storage";
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

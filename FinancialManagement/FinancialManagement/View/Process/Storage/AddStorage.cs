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
    public partial class AddStorage : Form
    {
        int addControl;
        string error;
        public AddStorage()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            cityCmb.SelectedIndex = -1;
            nameTxt.Text = "";
            capacityNmrc.Value = 0;
            mCapacityNmrc.Value = 0;
            statusCb.Checked = false;
            storageDGV.DataSource = StorageProcess.GetStorage();
        }
        private void AddStorage_Load(object sender, EventArgs e)
        {
            storageDGV.DataSource= StorageProcess.GetStorage();
            storageDGV.Columns[0].Visible = false;
            cityCmb.DataSource = StorageProcess.FillComboBox();
            cityCmb.ValueMember = "Id";
            cityCmb.DisplayMember = "Name";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text!=""&&cityCmb.SelectedIndex!=-1&&capacityNmrc.Value!=0&&mCapacityNmrc.Value!=0)
            {
                addControl = StorageProcess.AddStorage(nameTxt.Text,Convert.ToInt32(cityCmb.SelectedValue), Convert.ToDouble(capacityNmrc.Value), Convert.ToDouble(mCapacityNmrc.Value),statusCb.Checked);
                error = ((StorageEnum)addControl).ToString();
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

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

namespace FinancialManagement.View.Process.Transfer
{
    public partial class AddTransfer : Form
    {
        int addControl;
        string error;
        public AddTransfer()
        {
            InitializeComponent();
        }
        private void AddTransfer_Load(object sender, EventArgs e)
        {
            transferDgv.DataSource = TransferProcess.GetTransfer();
            transferDgv.Columns[0].Visible = false;
        }
        public void Reset()
        {
            this.transferDgv.DataSource = TransferProcess.GetTransfer();
            cargoNmrc.Value = 0;
            carNmrc.Value = 0;
            entranceStorageNmrc.Value = 0;
            outStorageNmrc.Value = 0;
            personalNmrc.Value = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (outStorageNmrc.Value!= 0 &&entranceStorageNmrc.Value!=0&&cargoNmrc.Value!=0&&carNmrc.Value!=0&&personalNmrc.Value!=0)
            {
                addControl = TransferProcess.AddTransfer((int)outStorageNmrc.Value, (int)entranceStorageNmrc.Value, (int)cargoNmrc.Value, (int)personalNmrc.Value, (int)carNmrc.Value);
                error = ((TransferEnum)addControl).ToString();
                MessageBox.Show(error);
                Reset();
            }
            else
            {
                error = "Fill all area.";
                MessageBox.Show(error);
                Reset();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

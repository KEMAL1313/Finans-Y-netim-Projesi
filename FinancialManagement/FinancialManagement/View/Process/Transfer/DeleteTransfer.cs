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
    public partial class DeleteTransfer : Form
    {
        int deleteId;
        string error;
        int deleteControl;
        public DeleteTransfer()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            this.transferDgv.DataSource = TransferProcess.GetTransfer();
            cargoNmrc.Value = 0;
            carNmrc.Value = 0;
            entranceStorageNmrc.Value = 0;
            outStorageNmrc.Value = 0;
            personalNmrc.Value = 0;
            deleteId = 0;
        }
        private void DeleteTransfer_Load(object sender, EventArgs e)
        {
            transferDgv.DataSource = TransferProcess.GetTransfer();
            transferDgv.Columns[0].Visible = false;
        }

        private void transferDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteId= Convert.ToInt32(transferDgv.CurrentRow.Cells[0].Value);
            cargoNmrc.Value = Convert.ToInt32(transferDgv.CurrentRow.Cells[5].Value);
            carNmrc.Value = Convert.ToInt32(transferDgv.CurrentRow.Cells[3].Value);
            entranceStorageNmrc.Value = Convert.ToInt32(transferDgv.CurrentRow.Cells[2].Value);
            outStorageNmrc.Value = Convert.ToInt32(transferDgv.CurrentRow.Cells[1].Value);
            personalNmrc.Value = Convert.ToInt32(transferDgv.CurrentRow.Cells[4].Value);
            statusCb.Checked = Convert.ToBoolean(transferDgv.CurrentRow.Cells[6].Value);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (deleteId!=0)
            {
                deleteControl =TransferProcess.DeleteTransfer(deleteId);
                error = ((TransferEnum)deleteControl).ToString();
                MessageBox.Show(error);
                Reset();
            }
            else
            {
                error = "Please select transfer.";
                MessageBox.Show(error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

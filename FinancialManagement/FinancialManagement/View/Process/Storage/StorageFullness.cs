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
    public partial class StorageFullness : Form
    {
        public StorageFullness()
        {
            InitializeComponent();
        }

        private void StorageFullness_Load(object sender, EventArgs e)
        {
            fullnessDgv.DataSource = StorageProcess.FullnessStorage();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

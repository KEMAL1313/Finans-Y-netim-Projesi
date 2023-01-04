using FinancialManagement.View.AccountingOffice.Income_Expense;
using FinancialManagement.View.AccountingOffice.Statement;
using FinancialManagement.View.HR;
using FinancialManagement.View.Process.Transfer;
using FinancialManagement.View.Services.Car;
using FinancialManagement.View.Services.City;
using FinancialManagement.View.Services.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagement.View
{
    public partial class FinancieMenu : Form
    {
        public FinancieMenu()
        {
            InitializeComponent();
        }
        private void addCityTSMItem_Click(object sender, EventArgs e)
        {
            AddCity addCity = new AddCity();
            this.Hide();
            addCity.ShowDialog();
            this.Show();
        }
        private void deleteCityTSMItem_Click(object sender, EventArgs e)
        {
            DeleteCity deleteCity = new DeleteCity();
            this.Hide();
            deleteCity.ShowDialog();
            this.Show(Owner);
        }
        private void editCityTSMItem_Click(object sender, EventArgs e)
        {
            EditCity editCity = new EditCity();
            this.Hide();
            editCity.ShowDialog();
            this.Show();
        }
        private void addStorageTSMItem_Click(object sender, EventArgs e)
        {
            AddStorage addStorage = new AddStorage();
            this.Hide();
            addStorage.ShowDialog();
            this.Show();
        }
        private void deleteStorageTSMItem_Click(object sender, EventArgs e)
        {
            DeleteStorage deleteStorage = new DeleteStorage();
            this.Hide();
            deleteStorage.ShowDialog();
            this.Show();
        }
        private void fullnessStorageTSMItem_Click(object sender, EventArgs e)
        {
            StorageFullness storageFullness = new StorageFullness();
            this.Hide();
            storageFullness.ShowDialog();
            this.Show();
        }
        private void editStorageTSMItem_Click(object sender, EventArgs e)
        {
            EditStorage editStorage = new EditStorage();
            this.Hide();
            editStorage.ShowDialog();
            this.Show();
        }
        private void addCarTSMItem_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            this.Hide();
            addCar.ShowDialog();
            this.Show();
        }
        private void deleteCarTSMItem_Click(object sender, EventArgs e)
        {
            DeleteCar deleteCar = new DeleteCar();
            this.Hide();
            deleteCar.ShowDialog();
            this.Show();
        }
        private void editCarTSMItem_Click(object sender, EventArgs e)
        {
            EditCar editCar = new EditCar();
            this.Hide();
            editCar.ShowDialog();
            this.Show();
        }
        private void addCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCV addCV = new AddCV();
            this.Hide();
            addCV.ShowDialog();
            this.Show();
        }
        private void recruitmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recruitment recruitment = new Recruitment();
            this.Hide();
            recruitment.ShowDialog();
            this.Show();
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            this.Hide();
            employee.ShowDialog();
            this.Show();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            this.Hide();
            delete.ShowDialog();
            this.Show();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            this.Hide();
            edit.ShowDialog();
            this.Show();
        }
        private void ıncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Income income=new Income();
            this.Hide();
            income.ShowDialog();
            this.Show();
        }
        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expense expense=new Expense();
            this.Hide();
            expense.ShowDialog(); 
            this.Show();
        }

        private void addTransferTSMItem_Click(object sender, EventArgs e)
        {
            AddTransfer addTransfer = new AddTransfer();
            this.Hide();
            addTransfer.ShowDialog();
            this.Show();
        }

        private void deleteTransferTSMItem_Click(object sender, EventArgs e)
        {
            DeleteTransfer deleteTransfer = new DeleteTransfer();
            this.Hide();
            deleteTransfer.ShowDialog();
            this.Show();
        }

        private void editTransferTSMItem_Click(object sender, EventArgs e)
        {
            EditTransfer editTransfer = new EditTransfer();
            this.Hide();
            editTransfer.ShowDialog();
            this.Show();
        }

        private void FinancieMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

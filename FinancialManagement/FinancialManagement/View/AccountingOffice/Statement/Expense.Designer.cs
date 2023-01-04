namespace FinancialManagement.View.AccountingOffice.Statement
{
    partial class Expense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.expenseLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculatIncomeBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.expenseDgv = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseLbl
            // 
            this.expenseLbl.AutoSize = true;
            this.expenseLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseLbl.Location = new System.Drawing.Point(665, 451);
            this.expenseLbl.Name = "expenseLbl";
            this.expenseLbl.Size = new System.Drawing.Size(0, 22);
            this.expenseLbl.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(534, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Expense:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatIncomeBtn
            // 
            this.calculatIncomeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculatIncomeBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculatIncomeBtn.Location = new System.Drawing.Point(318, 435);
            this.calculatIncomeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculatIncomeBtn.Name = "calculatIncomeBtn";
            this.calculatIncomeBtn.Size = new System.Drawing.Size(199, 57);
            this.calculatIncomeBtn.TabIndex = 9;
            this.calculatIncomeBtn.Text = "Calculate Expense";
            this.calculatIncomeBtn.UseVisualStyleBackColor = false;
            this.calculatIncomeBtn.Click += new System.EventHandler(this.calculatIncomeBtn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(318, 384);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(198, 27);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 307);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // expenseDgv
            // 
            this.expenseDgv.AllowUserToAddRows = false;
            this.expenseDgv.AllowUserToDeleteRows = false;
            this.expenseDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.expenseDgv.Location = new System.Drawing.Point(0, 0);
            this.expenseDgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expenseDgv.Name = "expenseDgv";
            this.expenseDgv.ReadOnly = true;
            this.expenseDgv.RowHeadersWidth = 51;
            this.expenseDgv.RowTemplate.Height = 25;
            this.expenseDgv.Size = new System.Drawing.Size(914, 260);
            this.expenseDgv.TabIndex = 6;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(14, 499);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(73, 85);
            this.backBtn.TabIndex = 12;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinancialManagement.Properties.Resources.pngwing_com__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.expenseLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculatIncomeBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.expenseDgv);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Expense";
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenseDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label expenseLbl;
        private Label label1;
        private Button calculatIncomeBtn;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView expenseDgv;
        private Button backBtn;
    }
}
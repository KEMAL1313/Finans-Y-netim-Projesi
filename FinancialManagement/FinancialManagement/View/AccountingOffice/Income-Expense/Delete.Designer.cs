namespace FinancialManagement.View.AccountingOffice.Income_Expense
{
    partial class Delete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.incomeDeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IncomeDgw = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.expenseDeleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.expenseDgw = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDgw)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.incomeDeleteBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.IncomeDgw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 749);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(647, 648);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(73, 85);
            this.backBtn.TabIndex = 10;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // incomeDeleteBtn
            // 
            this.incomeDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.incomeDeleteBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.incomeDeleteBtn.Location = new System.Drawing.Point(595, 123);
            this.incomeDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incomeDeleteBtn.Name = "incomeDeleteBtn";
            this.incomeDeleteBtn.Size = new System.Drawing.Size(169, 47);
            this.incomeDeleteBtn.TabIndex = 3;
            this.incomeDeleteBtn.Text = "Delete";
            this.incomeDeleteBtn.UseVisualStyleBackColor = false;
            this.incomeDeleteBtn.Click += new System.EventHandler(this.incomeDeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(595, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(635, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 27);
            this.textBox1.TabIndex = 1;
            // 
            // IncomeDgw
            // 
            this.IncomeDgw.AllowUserToAddRows = false;
            this.IncomeDgw.AllowUserToDeleteRows = false;
            this.IncomeDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IncomeDgw.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.IncomeDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeDgw.Dock = System.Windows.Forms.DockStyle.Left;
            this.IncomeDgw.Location = new System.Drawing.Point(0, 0);
            this.IncomeDgw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IncomeDgw.Name = "IncomeDgw";
            this.IncomeDgw.ReadOnly = true;
            this.IncomeDgw.RowHeadersWidth = 51;
            this.IncomeDgw.RowTemplate.Height = 25;
            this.IncomeDgw.Size = new System.Drawing.Size(551, 749);
            this.IncomeDgw.TabIndex = 0;
            this.IncomeDgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncomeDgw_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.expenseDeleteBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.expenseDgw);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(822, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 749);
            this.panel2.TabIndex = 1;
            // 
            // expenseDeleteBtn
            // 
            this.expenseDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.expenseDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expenseDeleteBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expenseDeleteBtn.Location = new System.Drawing.Point(11, 123);
            this.expenseDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expenseDeleteBtn.Name = "expenseDeleteBtn";
            this.expenseDeleteBtn.Size = new System.Drawing.Size(169, 47);
            this.expenseDeleteBtn.TabIndex = 6;
            this.expenseDeleteBtn.Text = "Delete";
            this.expenseDeleteBtn.UseVisualStyleBackColor = false;
            this.expenseDeleteBtn.Click += new System.EventHandler(this.expenseDeleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id:";
            // 
            // expenseDgw
            // 
            this.expenseDgw.AllowUserToAddRows = false;
            this.expenseDgw.AllowUserToDeleteRows = false;
            this.expenseDgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseDgw.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.expenseDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseDgw.Dock = System.Windows.Forms.DockStyle.Right;
            this.expenseDgw.Location = new System.Drawing.Point(211, 0);
            this.expenseDgw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expenseDgw.Name = "expenseDgw";
            this.expenseDgw.ReadOnly = true;
            this.expenseDgw.RowHeadersWidth = 51;
            this.expenseDgw.RowTemplate.Height = 25;
            this.expenseDgw.Size = new System.Drawing.Size(542, 749);
            this.expenseDgw.TabIndex = 0;
            this.expenseDgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseDgw_CellDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(51, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 27);
            this.textBox2.TabIndex = 4;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinancialManagement.Properties.Resources.pngwing_com__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1575, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDgw)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button incomeDeleteBtn;
        private Label label1;
        private TextBox textBox1;
        private DataGridView IncomeDgw;
        private Panel panel2;
        private Button expenseDeleteBtn;
        private Label label2;
        private DataGridView expenseDgw;
        private TextBox textBox2;
        private Button backBtn;
    }
}
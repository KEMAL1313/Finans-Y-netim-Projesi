namespace FinancialManagement.View.AccountingOffice.Statement
{
    partial class Income
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
            this.incomeDgv = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.calculatIncomeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeDgv
            // 
            this.incomeDgv.AllowUserToAddRows = false;
            this.incomeDgv.AllowUserToDeleteRows = false;
            this.incomeDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomeDgv.Location = new System.Drawing.Point(0, 0);
            this.incomeDgv.Name = "incomeDgv";
            this.incomeDgv.ReadOnly = true;
            this.incomeDgv.RowHeadersWidth = 51;
            this.incomeDgv.RowTemplate.Height = 25;
            this.incomeDgv.Size = new System.Drawing.Size(679, 195);
            this.incomeDgv.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(230, 281);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // calculatIncomeBtn
            // 
            this.calculatIncomeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculatIncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculatIncomeBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculatIncomeBtn.Location = new System.Drawing.Point(230, 319);
            this.calculatIncomeBtn.Name = "calculatIncomeBtn";
            this.calculatIncomeBtn.Size = new System.Drawing.Size(174, 43);
            this.calculatIncomeBtn.TabIndex = 3;
            this.calculatIncomeBtn.Text = "Calculate Income";
            this.calculatIncomeBtn.UseVisualStyleBackColor = false;
            this.calculatIncomeBtn.Click += new System.EventHandler(this.calculatIncomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(419, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Income:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incomeLbl.Location = new System.Drawing.Point(526, 331);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(0, 19);
            this.incomeLbl.TabIndex = 5;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(12, 375);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(64, 64);
            this.backBtn.TabIndex = 10;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinancialManagement.Properties.Resources.pngwing_com__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 451);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculatIncomeBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.incomeDgv);
            this.DoubleBuffered = true;
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView incomeDgv;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button calculatIncomeBtn;
        private Label label1;
        private Label incomeLbl;
        private Button backBtn;
    }
}
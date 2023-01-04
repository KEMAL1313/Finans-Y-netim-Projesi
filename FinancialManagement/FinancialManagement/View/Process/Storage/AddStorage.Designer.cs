namespace FinancialManagement.View.Services.Storage
{
    partial class AddStorage
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
            this.storageDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusCb = new System.Windows.Forms.CheckBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.mCapacityNmrc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.capacityNmrc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cityCmb = new System.Windows.Forms.ComboBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mCapacityNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNmrc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.storageDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(425, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 600);
            this.panel1.TabIndex = 0;
            // 
            // storageDGV
            // 
            this.storageDGV.AllowUserToAddRows = false;
            this.storageDGV.AllowUserToDeleteRows = false;
            this.storageDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storageDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.storageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageDGV.Location = new System.Drawing.Point(0, 0);
            this.storageDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storageDGV.Name = "storageDGV";
            this.storageDGV.ReadOnly = true;
            this.storageDGV.RowHeadersWidth = 51;
            this.storageDGV.RowTemplate.Height = 25;
            this.storageDGV.Size = new System.Drawing.Size(489, 600);
            this.storageDGV.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.statusCb);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.mCapacityNmrc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.capacityNmrc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cityCmb);
            this.panel2.Controls.Add(this.nameTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 600);
            this.panel2.TabIndex = 1;
            // 
            // statusCb
            // 
            this.statusCb.AutoSize = true;
            this.statusCb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusCb.Location = new System.Drawing.Point(111, 351);
            this.statusCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusCb.Name = "statusCb";
            this.statusCb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusCb.Size = new System.Drawing.Size(92, 31);
            this.statusCb.TabIndex = 10;
            this.statusCb.Text = "Status";
            this.statusCb.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(14, 499);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(73, 85);
            this.backBtn.TabIndex = 9;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(111, 392);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(210, 55);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Storage";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // mCapacityNmrc
            // 
            this.mCapacityNmrc.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.mCapacityNmrc.Location = new System.Drawing.Point(110, 312);
            this.mCapacityNmrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mCapacityNmrc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.mCapacityNmrc.Name = "mCapacityNmrc";
            this.mCapacityNmrc.Size = new System.Drawing.Size(210, 27);
            this.mCapacityNmrc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(110, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "MaxCapacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacity";
            // 
            // capacityNmrc
            // 
            this.capacityNmrc.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.capacityNmrc.Location = new System.Drawing.Point(110, 233);
            this.capacityNmrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capacityNmrc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.capacityNmrc.Name = "capacityNmrc";
            this.capacityNmrc.Size = new System.Drawing.Size(210, 27);
            this.capacityNmrc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(110, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // cityCmb
            // 
            this.cityCmb.FormattingEnabled = true;
            this.cityCmb.Location = new System.Drawing.Point(110, 155);
            this.cityCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityCmb.Name = "cityCmb";
            this.cityCmb.Size = new System.Drawing.Size(210, 28);
            this.cityCmb.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(110, 76);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(210, 27);
            this.nameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // AddStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStorage";
            this.Load += new System.EventHandler(this.AddStorage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mCapacityNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNmrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView storageDGV;
        private Panel panel2;
        private Button addBtn;
        private NumericUpDown mCapacityNmrc;
        private Label label4;
        private Label label3;
        private NumericUpDown capacityNmrc;
        private Label label2;
        private ComboBox cityCmb;
        private TextBox nameTxt;
        private Label label1;
        private Button backBtn;
        private CheckBox statusCb;
    }
}
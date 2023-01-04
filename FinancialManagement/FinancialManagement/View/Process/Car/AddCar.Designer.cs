namespace FinancialManagement.View.Services.Car
{
    partial class AddCar
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
            this.carDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.capacityNmrc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.brandTxt = new System.Windows.Forms.TextBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.statusCb = new System.Windows.Forms.CheckBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNmrc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.carDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(425, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 600);
            this.panel1.TabIndex = 2;
            // 
            // carDGV
            // 
            this.carDGV.AllowUserToAddRows = false;
            this.carDGV.AllowUserToDeleteRows = false;
            this.carDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.carDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carDGV.Location = new System.Drawing.Point(0, 0);
            this.carDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carDGV.Name = "carDGV";
            this.carDGV.ReadOnly = true;
            this.carDGV.RowHeadersWidth = 51;
            this.carDGV.RowTemplate.Height = 25;
            this.carDGV.Size = new System.Drawing.Size(489, 600);
            this.carDGV.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.capacityNmrc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.brandTxt);
            this.panel2.Controls.Add(this.modelTxt);
            this.panel2.Controls.Add(this.statusCb);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.plateTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 600);
            this.panel2.TabIndex = 3;
            // 
            // capacityNmrc
            // 
            this.capacityNmrc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.capacityNmrc.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.capacityNmrc.Location = new System.Drawing.Point(111, 312);
            this.capacityNmrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capacityNmrc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.capacityNmrc.Name = "capacityNmrc";
            this.capacityNmrc.Size = new System.Drawing.Size(210, 27);
            this.capacityNmrc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(111, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Capacity";
            // 
            // brandTxt
            // 
            this.brandTxt.Location = new System.Drawing.Point(110, 155);
            this.brandTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brandTxt.Name = "brandTxt";
            this.brandTxt.Size = new System.Drawing.Size(210, 27);
            this.brandTxt.TabIndex = 12;
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(111, 233);
            this.modelTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(210, 27);
            this.modelTxt.TabIndex = 11;
            // 
            // statusCb
            // 
            this.statusCb.AutoSize = true;
            this.statusCb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusCb.Location = new System.Drawing.Point(110, 363);
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
            this.addBtn.Location = new System.Drawing.Point(110, 417);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(211, 55);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Car";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(110, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand";
            // 
            // plateTxt
            // 
            this.plateTxt.Location = new System.Drawing.Point(110, 76);
            this.plateTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plateTxt.Name = "plateTxt";
            this.plateTxt.Size = new System.Drawing.Size(210, 27);
            this.plateTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNmrc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView carDGV;
        private Panel panel2;
        private TextBox brandTxt;
        private TextBox modelTxt;
        private CheckBox statusCb;
        private Button backBtn;
        private Button addBtn;
        private Label label3;
        private Label label2;
        private TextBox plateTxt;
        private Label label1;
        private Label label4;
        private NumericUpDown capacityNmrc;
    }
}
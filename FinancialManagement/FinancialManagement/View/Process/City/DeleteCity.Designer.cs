namespace FinancialManagement.View.Services.City
{
    partial class DeleteCity
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
            this.cityDGV = new System.Windows.Forms.DataGridView();
            this.cityInputPnl = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.statusCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.locationNmrc = new System.Windows.Forms.NumericUpDown();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.cityDGVPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cityDGV)).BeginInit();
            this.cityInputPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationNmrc)).BeginInit();
            this.cityDGVPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityDGV
            // 
            this.cityDGV.AllowUserToAddRows = false;
            this.cityDGV.AllowUserToDeleteRows = false;
            this.cityDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cityDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.cityDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityDGV.Location = new System.Drawing.Point(0, 0);
            this.cityDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityDGV.Name = "cityDGV";
            this.cityDGV.ReadOnly = true;
            this.cityDGV.RowHeadersWidth = 51;
            this.cityDGV.RowTemplate.Height = 25;
            this.cityDGV.Size = new System.Drawing.Size(527, 600);
            this.cityDGV.TabIndex = 0;
            this.cityDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cityDGV_CellDoubleClick);
            // 
            // cityInputPnl
            // 
            this.cityInputPnl.AutoSize = true;
            this.cityInputPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cityInputPnl.Controls.Add(this.backBtn);
            this.cityInputPnl.Controls.Add(this.deleteBtn);
            this.cityInputPnl.Controls.Add(this.statusCB);
            this.cityInputPnl.Controls.Add(this.label1);
            this.cityInputPnl.Controls.Add(this.locationNmrc);
            this.cityInputPnl.Controls.Add(this.nameTxt);
            this.cityInputPnl.Controls.Add(this.nameLbl);
            this.cityInputPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityInputPnl.Location = new System.Drawing.Point(0, 0);
            this.cityInputPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityInputPnl.Name = "cityInputPnl";
            this.cityInputPnl.Size = new System.Drawing.Size(387, 600);
            this.cityInputPnl.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(14, 487);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(73, 85);
            this.backBtn.TabIndex = 6;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(41, 257);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(251, 59);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete City";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // statusCB
            // 
            this.statusCB.AutoSize = true;
            this.statusCB.Enabled = false;
            this.statusCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusCB.Location = new System.Drawing.Point(41, 216);
            this.statusCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusCB.Name = "statusCB";
            this.statusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusCB.Size = new System.Drawing.Size(92, 31);
            this.statusCB.TabIndex = 4;
            this.statusCB.Text = "Status";
            this.statusCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Location";
            // 
            // locationNmrc
            // 
            this.locationNmrc.Enabled = false;
            this.locationNmrc.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.locationNmrc.Location = new System.Drawing.Point(41, 163);
            this.locationNmrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationNmrc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.locationNmrc.Name = "locationNmrc";
            this.locationNmrc.Size = new System.Drawing.Size(251, 27);
            this.locationNmrc.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Location = new System.Drawing.Point(41, 76);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(251, 27);
            this.nameTxt.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(41, 44);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(69, 27);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // cityDGVPnl
            // 
            this.cityDGVPnl.Controls.Add(this.cityDGV);
            this.cityDGVPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.cityDGVPnl.Location = new System.Drawing.Point(387, 0);
            this.cityDGVPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityDGVPnl.Name = "cityDGVPnl";
            this.cityDGVPnl.Size = new System.Drawing.Size(527, 600);
            this.cityDGVPnl.TabIndex = 2;
            // 
            // DeleteCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.cityInputPnl);
            this.Controls.Add(this.cityDGVPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financie";
            this.Load += new System.EventHandler(this.DeleteCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityDGV)).EndInit();
            this.cityInputPnl.ResumeLayout(false);
            this.cityInputPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationNmrc)).EndInit();
            this.cityDGVPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView cityDGV;
        private Panel cityInputPnl;
        private Button backBtn;
        private Button deleteBtn;
        private CheckBox statusCB;
        private Label label1;
        private NumericUpDown locationNmrc;
        private TextBox nameTxt;
        private Label nameLbl;
        private Panel cityDGVPnl;
    }
}
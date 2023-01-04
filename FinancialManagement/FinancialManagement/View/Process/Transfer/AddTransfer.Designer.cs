namespace FinancialManagement.View.Process.Transfer
{
    partial class AddTransfer
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
            this.transferDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outStorageNmrc = new System.Windows.Forms.NumericUpDown();
            this.entranceStorageNmrc = new System.Windows.Forms.NumericUpDown();
            this.cargoNmrc = new System.Windows.Forms.NumericUpDown();
            this.carNmrc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.personalNmrc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transferDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outStorageNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceStorageNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalNmrc)).BeginInit();
            this.SuspendLayout();
            // 
            // transferDgv
            // 
            this.transferDgv.AllowUserToAddRows = false;
            this.transferDgv.AllowUserToDeleteRows = false;
            this.transferDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transferDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferDgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.transferDgv.Location = new System.Drawing.Point(335, 0);
            this.transferDgv.Name = "transferDgv";
            this.transferDgv.ReadOnly = true;
            this.transferDgv.RowTemplate.Height = 25;
            this.transferDgv.Size = new System.Drawing.Size(465, 450);
            this.transferDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Out Storage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entrance Storage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cargo Space";
            // 
            // outStorageNmrc
            // 
            this.outStorageNmrc.Location = new System.Drawing.Point(100, 77);
            this.outStorageNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.outStorageNmrc.Name = "outStorageNmrc";
            this.outStorageNmrc.Size = new System.Drawing.Size(120, 23);
            this.outStorageNmrc.TabIndex = 6;
            // 
            // entranceStorageNmrc
            // 
            this.entranceStorageNmrc.Location = new System.Drawing.Point(100, 139);
            this.entranceStorageNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.entranceStorageNmrc.Name = "entranceStorageNmrc";
            this.entranceStorageNmrc.Size = new System.Drawing.Size(120, 23);
            this.entranceStorageNmrc.TabIndex = 7;
            // 
            // cargoNmrc
            // 
            this.cargoNmrc.Location = new System.Drawing.Point(100, 203);
            this.cargoNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cargoNmrc.Name = "cargoNmrc";
            this.cargoNmrc.Size = new System.Drawing.Size(120, 23);
            this.cargoNmrc.TabIndex = 8;
            // 
            // carNmrc
            // 
            this.carNmrc.Location = new System.Drawing.Point(100, 262);
            this.carNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.carNmrc.Name = "carNmrc";
            this.carNmrc.Size = new System.Drawing.Size(120, 23);
            this.carNmrc.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(100, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Car Id";
            // 
            // personalNmrc
            // 
            this.personalNmrc.Location = new System.Drawing.Point(100, 318);
            this.personalNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.personalNmrc.Name = "personalNmrc";
            this.personalNmrc.Size = new System.Drawing.Size(120, 23);
            this.personalNmrc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(100, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Personal Id";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(100, 347);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 39);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(12, 374);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(64, 64);
            this.backBtn.TabIndex = 14;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.personalNmrc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carNmrc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cargoNmrc);
            this.Controls.Add(this.entranceStorageNmrc);
            this.Controls.Add(this.outStorageNmrc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transferDgv);
            this.Name = "AddTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTransfer";
            this.Load += new System.EventHandler(this.AddTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transferDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outStorageNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceStorageNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalNmrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView transferDgv;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown outStorageNmrc;
        private NumericUpDown entranceStorageNmrc;
        private NumericUpDown cargoNmrc;
        private NumericUpDown carNmrc;
        private Label label4;
        private NumericUpDown personalNmrc;
        private Label label5;
        private Button addBtn;
        private Button backBtn;
    }
}
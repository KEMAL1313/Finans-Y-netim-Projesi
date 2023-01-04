namespace FinancialManagement.View.Process.Transfer
{
    partial class EditTransfer
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
            this.statusCb = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.personalNmrc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.carNmrc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cargoNmrc = new System.Windows.Forms.NumericUpDown();
            this.entranceStorageNmrc = new System.Windows.Forms.NumericUpDown();
            this.outStorageNmrc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transferDgv = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceStorageNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outStorageNmrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // statusCb
            // 
            this.statusCb.AutoSize = true;
            this.statusCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusCb.Location = new System.Drawing.Point(103, 333);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(65, 23);
            this.statusCb.TabIndex = 38;
            this.statusCb.Text = "Status";
            this.statusCb.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(103, 376);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 39);
            this.deleteBtn.TabIndex = 37;
            this.deleteBtn.Text = "Edit";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // personalNmrc
            // 
            this.personalNmrc.Location = new System.Drawing.Point(103, 295);
            this.personalNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.personalNmrc.Name = "personalNmrc";
            this.personalNmrc.Size = new System.Drawing.Size(120, 23);
            this.personalNmrc.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Personal Id";
            // 
            // carNmrc
            // 
            this.carNmrc.Location = new System.Drawing.Point(103, 239);
            this.carNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.carNmrc.Name = "carNmrc";
            this.carNmrc.Size = new System.Drawing.Size(120, 23);
            this.carNmrc.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(103, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Car Id";
            // 
            // cargoNmrc
            // 
            this.cargoNmrc.Location = new System.Drawing.Point(103, 180);
            this.cargoNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cargoNmrc.Name = "cargoNmrc";
            this.cargoNmrc.Size = new System.Drawing.Size(120, 23);
            this.cargoNmrc.TabIndex = 32;
            // 
            // entranceStorageNmrc
            // 
            this.entranceStorageNmrc.Location = new System.Drawing.Point(103, 116);
            this.entranceStorageNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.entranceStorageNmrc.Name = "entranceStorageNmrc";
            this.entranceStorageNmrc.Size = new System.Drawing.Size(120, 23);
            this.entranceStorageNmrc.TabIndex = 31;
            // 
            // outStorageNmrc
            // 
            this.outStorageNmrc.Location = new System.Drawing.Point(103, 54);
            this.outStorageNmrc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.outStorageNmrc.Name = "outStorageNmrc";
            this.outStorageNmrc.Size = new System.Drawing.Size(120, 23);
            this.outStorageNmrc.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cargo Space";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Entrance Storage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Out Storage";
            // 
            // transferDgv
            // 
            this.transferDgv.AllowUserToAddRows = false;
            this.transferDgv.AllowUserToDeleteRows = false;
            this.transferDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transferDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferDgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.transferDgv.Location = new System.Drawing.Point(370, 0);
            this.transferDgv.Name = "transferDgv";
            this.transferDgv.ReadOnly = true;
            this.transferDgv.RowTemplate.Height = 25;
            this.transferDgv.Size = new System.Drawing.Size(430, 450);
            this.transferDgv.TabIndex = 26;
            this.transferDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transferDgv_CellDoubleClick);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(12, 376);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(64, 64);
            this.backBtn.TabIndex = 39;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // EditTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.statusCb);
            this.Controls.Add(this.deleteBtn);
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
            this.Name = "EditTransfer";
            this.Text = "EditTransfer";
            this.Load += new System.EventHandler(this.EditTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entranceStorageNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outStorageNmrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox statusCb;
        private Button deleteBtn;
        private NumericUpDown personalNmrc;
        private Label label5;
        private NumericUpDown carNmrc;
        private Label label4;
        private NumericUpDown cargoNmrc;
        private NumericUpDown entranceStorageNmrc;
        private NumericUpDown outStorageNmrc;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView transferDgv;
        private Button backBtn;
    }
}
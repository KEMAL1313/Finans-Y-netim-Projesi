namespace FinancialManagement.View.Services.Storage
{
    partial class StorageFullness
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
            this.fullnessDgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullnessDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.fullnessDgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 600);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::FinancialManagement.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(14, 499);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(73, 85);
            this.backBtn.TabIndex = 10;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // fullnessDgv
            // 
            this.fullnessDgv.AllowUserToAddRows = false;
            this.fullnessDgv.AllowUserToDeleteRows = false;
            this.fullnessDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fullnessDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.fullnessDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullnessDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.fullnessDgv.Location = new System.Drawing.Point(0, 0);
            this.fullnessDgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullnessDgv.Name = "fullnessDgv";
            this.fullnessDgv.ReadOnly = true;
            this.fullnessDgv.RowHeadersWidth = 51;
            this.fullnessDgv.RowTemplate.Height = 25;
            this.fullnessDgv.Size = new System.Drawing.Size(632, 461);
            this.fullnessDgv.TabIndex = 0;
            // 
            // StorageFullness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StorageFullness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageFullness";
            this.Load += new System.EventHandler(this.StorageFullness_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullnessDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView fullnessDgv;
        private Button backBtn;
    }
}
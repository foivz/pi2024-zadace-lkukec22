namespace VarazdinBus
{
    partial class frm_Schedule
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
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labBrojAutobusa = new System.Windows.Forms.Label();
            this.lbDrivers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(776, 331);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(22, 35);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(100, 22);
            this.txtBusNumber.TabIndex = 1;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(158, 36);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(100, 22);
            this.txtDriverName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(284, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labBrojAutobusa
            // 
            this.labBrojAutobusa.AutoSize = true;
            this.labBrojAutobusa.Location = new System.Drawing.Point(19, 16);
            this.labBrojAutobusa.Name = "labBrojAutobusa";
            this.labBrojAutobusa.Size = new System.Drawing.Size(93, 16);
            this.labBrojAutobusa.TabIndex = 4;
            this.labBrojAutobusa.Text = "Broj autobusa:";
            // 
            // lbDrivers
            // 
            this.lbDrivers.AutoSize = true;
            this.lbDrivers.Location = new System.Drawing.Point(155, 17);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(48, 16);
            this.lbDrivers.TabIndex = 5;
            this.lbDrivers.Text = "Vozač:";
            // 
            // frm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDrivers);
            this.Controls.Add(this.labBrojAutobusa);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Name = "frm_Schedule";
            this.Text = "frm_Schedule";
            this.Load += new System.EventHandler(this.frm_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labBrojAutobusa;
        private System.Windows.Forms.Label lbDrivers;
    }
}
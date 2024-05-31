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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Schedule));
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labBrojAutobusa = new System.Windows.Forms.Label();
            this.lbDrivers = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(16, 87);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(1020, 455);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(28, 49);
            this.txtBusNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(124, 27);
            this.txtBusNumber.TabIndex = 1;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(198, 50);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(124, 27);
            this.txtDriverName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(356, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labBrojAutobusa
            // 
            this.labBrojAutobusa.AutoSize = true;
            this.labBrojAutobusa.Location = new System.Drawing.Point(23, 22);
            this.labBrojAutobusa.Name = "labBrojAutobusa";
            this.labBrojAutobusa.Size = new System.Drawing.Size(150, 22);
            this.labBrojAutobusa.TabIndex = 4;
            this.labBrojAutobusa.Text = "Broj autobusa:";
            // 
            // lbDrivers
            // 
            this.lbDrivers.AutoSize = true;
            this.lbDrivers.Location = new System.Drawing.Point(193, 23);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(70, 22);
            this.lbDrivers.TabIndex = 5;
            this.lbDrivers.Text = "Vozač:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(805, 595);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj podatke";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(587, 595);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(191, 31);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Ažuriraj podatke";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VarazdinBus.Properties.Resources.bus_png_2222;
            this.pictureBox1.InitialImage = global::VarazdinBus.Properties.Resources.bus_png_2222;
            this.pictureBox1.Location = new System.Drawing.Point(669, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 455);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 595);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Zatvori";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1475, 672);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbDrivers);
            this.Controls.Add(this.labBrojAutobusa);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frm_Schedule";
            this.Text = "Raspored reda vozača";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}
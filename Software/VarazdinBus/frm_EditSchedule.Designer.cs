namespace VarazdinBus
{
    partial class frm_EditSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditSchedule));
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.comboBoxWorkHours = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIdScheTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDriverId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(209, 97);
            this.txtBusNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(150, 27);
            this.txtBusNumber.TabIndex = 0;
            // 
            // comboBoxWorkHours
            // 
            this.comboBoxWorkHours.FormattingEnabled = true;
            this.comboBoxWorkHours.Location = new System.Drawing.Point(209, 165);
            this.comboBoxWorkHours.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWorkHours.Name = "comboBoxWorkHours";
            this.comboBoxWorkHours.Size = new System.Drawing.Size(150, 30);
            this.comboBoxWorkHours.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 318);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj autobusa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Radno vrijeme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID vozača:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 318);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Izbriši podatke";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIdScheTable
            // 
            this.txtIdScheTable.Location = new System.Drawing.Point(209, 40);
            this.txtIdScheTable.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdScheTable.Name = "txtIdScheTable";
            this.txtIdScheTable.ReadOnly = true;
            this.txtIdScheTable.Size = new System.Drawing.Size(124, 27);
            this.txtIdScheTable.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // txtDriverId
            // 
            this.txtDriverId.Location = new System.Drawing.Point(209, 233);
            this.txtDriverId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(150, 27);
            this.txtDriverId.TabIndex = 11;
            // 
            // frm_EditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(429, 389);
            this.Controls.Add(this.txtDriverId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdScheTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxWorkHours);
            this.Controls.Add(this.txtBusNumber);
            this.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_EditSchedule";
            this.Text = "Rad s tablicom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.ComboBox comboBoxWorkHours;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIdScheTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDriverId;
    }
}
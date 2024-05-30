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
            this.Bus_number = new System.Windows.Forms.TextBox();
            this.Work_hours = new System.Windows.Forms.TextBox();
            this.Driver = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bus_number
            // 
            this.Bus_number.Location = new System.Drawing.Point(51, 350);
            this.Bus_number.Name = "Bus_number";
            this.Bus_number.Size = new System.Drawing.Size(100, 22);
            this.Bus_number.TabIndex = 0;
            // 
            // Work_hours
            // 
            this.Work_hours.Location = new System.Drawing.Point(217, 350);
            this.Work_hours.Name = "Work_hours";
            this.Work_hours.Size = new System.Drawing.Size(100, 22);
            this.Work_hours.TabIndex = 1;
            // 
            // Driver
            // 
            this.Driver.FormattingEnabled = true;
            this.Driver.Location = new System.Drawing.Point(404, 350);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(121, 24);
            this.Driver.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(632, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj autobusa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Radno vrijeme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vozač";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(632, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Izbriši podatke";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frm_EditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.Work_hours);
            this.Controls.Add(this.Bus_number);
            this.Name = "frm_EditSchedule";
            this.Text = "frm_EditSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bus_number;
        private System.Windows.Forms.TextBox Work_hours;
        private System.Windows.Forms.ComboBox Driver;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
    }
}
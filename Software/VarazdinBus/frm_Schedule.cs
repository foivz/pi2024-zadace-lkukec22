using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VarazdinBus
{
    public partial class frm_Schedule : Form
    {
        public frm_Schedule()
        {
            InitializeComponent();
        }

        private void frm_Schedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
                DB.OpenConnection();
                
                string query = @"
                SELECT s.Id_SchTable, s.Bus_number, s.Work_hours,
                    CONCAT(drv.Firstname, ' ', drv.Surname) AS Driver_Name
                    FROM Schedule s
                    LEFT JOIN Drivers drv ON s.Id_Driver = drv.Id_Driver
                    WHERE (@BusNumber IS NULL OR s.Bus_number = @BusNumber)
                    AND (@DriverName IS NULL OR CONCAT(drv.Firstname, ' ', drv.Surname) LIKE '%' + @DriverName + '%')";

                
                SqlCommand command = new SqlCommand(query, DB.Connection);
                command.Parameters.AddWithValue("@BusNumber", string.IsNullOrEmpty(txtBusNumber.Text) ? (object)DBNull.Value : txtBusNumber.Text);
                command.Parameters.AddWithValue("@DriverName", string.IsNullOrEmpty(txtDriverName.Text) ? (object)DBNull.Value : txtDriverName.Text);

                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridViewSchedule.DataSource = dataTable;

                dataGridViewSchedule.Columns["Id_SchTable"].HeaderText = "ID";
                dataGridViewSchedule.Columns["Bus_number"].HeaderText = "Broj autobusa";
                dataGridViewSchedule.Columns["Work_hours"].HeaderText = "Radno Vrijeme";
                dataGridViewSchedule.Columns["Driver_Name"].HeaderText = "Vozač";

                dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                reader.Close();
            
                DB.CloseConnection();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_EditSchedule editForm = new frm_EditSchedule();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dataGridViewSchedule.CurrentRow.Cells["Id_SchTable"].Value);
                frm_EditSchedule editForm = new frm_EditSchedule(selectedId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

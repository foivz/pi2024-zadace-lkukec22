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
            try
            {
                DB.OpenConnection();
                
                string query = @"
                SELECT s.Id_SchTable, s.Bus_number, s.Work_hours, s.Id_DiffSchedule,
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

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

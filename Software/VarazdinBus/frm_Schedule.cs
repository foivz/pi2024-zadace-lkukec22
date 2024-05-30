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
            SELECT s.Id_SchTable, s.Bus_number, s.Work_hours,Id_DiffSchedule,
                
                CONCAT(drv.Firstname, ' ', drv.Surname) AS Driver_Name
            FROM Schedule s
            LEFT JOIN Drivers drv ON s.Id_Driver = drv.Id_Driver";
                SqlDataReader reader = DB.GetDataReader(query);

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


    }
}

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
                string query = "SELECT Id_SchTable, Bus_number, Work_hours, Id_DiffSchedule, Id_Driver FROM Schedule";
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

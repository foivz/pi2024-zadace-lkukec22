using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarazdinBus
{
    public partial class frm_EditSchedule : Form
    {
        private int? scheduleId;

        public frm_EditSchedule(int? id = null)
        {
            InitializeComponent();
            scheduleId = id;
            LoadWorkHours();

            if (scheduleId.HasValue)
            {
                LoadScheduleData(scheduleId.Value);
            }
            else
            {
                
                txtIdScheTable.Text = GetNextAvailableId().ToString();
                txtIdScheTable.Enabled = false; 
            }
        }

        private void LoadWorkHours()
        {
            comboBoxWorkHours.Items.AddRange(new object[] {
                "5:30-12:30",
                "12:30-20:30"
            });
            comboBoxWorkHours.SelectedIndex = 0;
        }

        private int GetNextAvailableId()
        {
            string sql = "SELECT ISNULL(MAX(Id_SchTable), 0) + 1 FROM Schedule";
            int nextId = 0;

            try
            {
                DB.OpenConnection();
                SqlCommand command = new SqlCommand(sql, DB.Connection);
                object result = command.ExecuteScalar();
                nextId = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while retrieving next available ID: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }

            return nextId;
        }

        private void LoadScheduleData(int id)
        {
            DB.OpenConnection();
            string query = $"SELECT * FROM Schedule WHERE Id_SchTable = {id}";
            SqlDataReader reader = DB.GetDataReader(query);

            if (reader.Read())
            {
                txtIdScheTable.Text = reader["Id_SchTable"].ToString();
                txtBusNumber.Text = reader["Bus_number"].ToString();
                comboBoxWorkHours.SelectedItem = reader["Work_hours"].ToString();
                txtDriverId.Text = reader["Id_Driver"].ToString();
            }

            reader.Close();
            DB.CloseConnection();
        }


        public static void InsertSchedule(int busNumber, string workHours, int driverId)
        {
            string sql = $"INSERT INTO Schedule (Bus_number, Work_hours, Id_Driver) " +
                         $"VALUES ({busNumber}, \'{workHours}\', {driverId})";
            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while inserting schedule: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public static void UpdateSchedule(int id, int busNumber, string workHours, int driverId)
        {
            string sql = $"UPDATE Schedule SET Bus_number = {busNumber}, Work_hours = '{workHours}', " +
                         $"Id_Driver = {driverId} WHERE Id_SchTable = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdScheTable.Text);
            int busNumber = int.Parse(txtBusNumber.Text);
            string workHours = comboBoxWorkHours.SelectedItem.ToString();
            int driverId = int.Parse(txtDriverId.Text);

            if (scheduleId.HasValue)
            {
                UpdateSchedule(scheduleId.Value, busNumber, workHours, driverId);
            }
            else
            {

                InsertSchedule( busNumber, workHours, driverId);
            }

            MessageBox.Show("Podaci su uspješno spremljeni.");
            DialogResult = DialogResult.OK;
            Close();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (scheduleId.HasValue)
            {
                var result = MessageBox.Show("Sigurno želiš izbrisati ovaj redak?", "Da Ne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteSchedule(scheduleId.Value);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void DeleteSchedule(int id)
        {
            DB.OpenConnection();
            string query = "DELETE FROM Schedule WHERE Id_SchTable = @Id";
            SqlCommand command = new SqlCommand(query, DB.Connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            DB.CloseConnection();
        }


    }
}
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
                "12:30-20:30",
                "20:30-4:30"
            });
            comboBoxWorkHours.SelectedIndex = 0;
        }

        private int GetNextAvailableId()
        {
            string sql = "SELECT ISNULL(MAX(Id_SchTable), 0) + 1 FROM Schedule";
            int nextId = 0;


                DB.OpenConnection();
                SqlCommand command = new SqlCommand(sql, DB.Connection);
                object result = command.ExecuteScalar();
                nextId = Convert.ToInt32(result);

                DB.CloseConnection();
            

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

                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            
        }

        public static void UpdateSchedule(int id, int busNumber, string workHours, int driverId)
        {
            string sql = $"UPDATE Schedule SET Bus_number = {busNumber}, Work_hours = '{workHours}', " +
                         $"Id_Driver = {driverId} WHERE Id_SchTable = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


        private bool IsDriverIdValid(int driverId)
        {
            string query = $"SELECT COUNT(*) FROM Drivers WHERE Id_Driver = {driverId}";
            int count = 0;


                DB.OpenConnection();
                SqlCommand command = new SqlCommand(query, DB.Connection);
                count = (int)command.ExecuteScalar();

            DB.CloseConnection();

            return count > 0;
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrEmpty(txtBusNumber.Text))
            {
                MessageBox.Show("Molimo unesite broj autobusa.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (comboBoxWorkHours.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite radno vrijeme.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtDriverId.Text))
            {
                MessageBox.Show("Molimo unesite ID vozača.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                return;
            }

            int busNumber = int.Parse(txtBusNumber.Text);
            string workHours = comboBoxWorkHours.SelectedItem.ToString();
            int driverId = int.Parse(txtDriverId.Text);

            if (!IsDriverIdValid(driverId))
            {
                MessageBox.Show("Uneseni ID vozača ne postoji u tablici vozača. Molimo unesite valjani ID vozača(1-3).", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (scheduleId.HasValue)
            {
                int id = int.Parse(txtIdScheTable.Text);
                UpdateSchedule(id, busNumber, workHours, driverId);
            }
            else
            {
                InsertSchedule(busNumber, workHours, driverId);
            }

            MessageBox.Show("Podaci su uspješno spremljeni.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
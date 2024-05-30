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
           
        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            
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
            try
            {
                DB.OpenConnection();
                string query = "DELETE FROM Schedule WHERE Id_SchTable = @Id";
                SqlCommand command = new SqlCommand(query, DB.Connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se greška prilikom brisanja reda: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Query_Visual_Version
{
    public partial class UpdateTableFrom : Form
    {
        private string tableName;
        public string ColumnName { get; private set; }
        public string NewValue { get; private set; }
        public string Condition { get; private set; }

        public UpdateTableFrom()
        {
            InitializeComponent();

        }

        private void UpdateTableFrom_Load(object sender, EventArgs e)
        {
            // Form yuklanganda kerakli dasturlarni yuklash
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Formdan qiymatlarni olish
            ColumnName = txtColumnName.Text; // txtColumnName - bu textbox
            NewValue = txtNewValue.Text; // txtNewValue - bu textbox
            Condition = txtCondition.Text; // txtCondition - bu textbox

            // SQL yangilanish so'rovini yaratish
            string query = $"UPDATE {Tables.SelectedTable} SET {ColumnName} = @NewValue WHERE {Condition}";

            using (var connection = new NpgsqlConnection(Form1.connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", NewValue);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} qator yangilandi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xato: {ex.Message}");
                    }
                }
            }
        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Tables tables = new Tables();
            tables.ShowDialog();
        }
    }
}

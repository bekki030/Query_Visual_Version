using Npgsql;

namespace Query_Visual_Version;

public partial class Tables : Form
{
    public Tables()
    {
        InitializeComponent();
    }

    private void Tables_Load(object sender, EventArgs e)
    {
        string query = @"select table_name from information_schema.tables where table_schema = 'public';";
        using (var connection = new NpgsqlConnection(Form1.connectionString))
        {
            connection.Open();
            var tables = new List<string>();

            using (var smd = new NpgsqlCommand(query, connection))
            {
                using (var reader = smd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tables.Add(reader.GetString(0));
                    }
                }
            }
            comboBox1.DataSource = tables;
        }

        //Functions.GetTables();
    }
    public static  string GetTableName()
    {
        return comboBox1.SelectedItem.ToString();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void addTableBtn_Click(object sender, EventArgs e)
    {
        TableColumnsFrom tableColumnsFrom = new TableColumnsFrom();
        Hide();
        tableColumnsFrom.ShowDialog();
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Hide();
        Form1 form = new Form1();
        form.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        string tableName = comboBox1.SelectedItem.ToString();
        using (var connection = new NpgsqlConnection(Form1.connectionString))
        {
            string query = $"DROP TABLE IF EXISTS {tableName}";

            try
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    Functions.GetTables();
                    MessageBox.Show($"Table '{tableName}' deleted sucsessfully.");

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        try
        {
            InsertTableForm insertTableForm = new InsertTableForm();
            Hide();
            insertTableForm.ShowDialog();
            Close();
        }
        catch
        {
            MessageBox.Show("Error");
        }
    }
}
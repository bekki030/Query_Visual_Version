using Npgsql;

namespace Query_Visual_Version;

public static class Functions
{
    public static void GetTables()
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

            //Tables.comboBox1.DataSource = tables;
        }
    }   

    public static ComboBox CreateCombo (int count)
    {
        var types = new ComboBox();
        types.Name = "typesCombo" + (count + 1).ToString();
        //types.Size = new Size()

        types.Items.Add("SERIAL");
        types.Items.Add("INT");
        types.Items.Add("TEXT");
        types.Items.Add("VARCHAR");
        types.Items.Add("DECIMAL");
        types.Items.Add("BIGINT");
        types.Items.Add("FLOAT");
        return types;
    }

    public static TextBox CreateTextBox(int count)
    {
        TextBox textBox = new TextBox();

        textBox.Name = "textBox" + (count + 1).ToString();
        textBox.Text = "column" + count.ToString();

        return textBox;
    }

    
}

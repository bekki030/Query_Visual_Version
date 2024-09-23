//using Npgsql;

//namespace Query_Visual_Version;

//public partial class TableColumnsFrom : Form
//{
//    Stack<TextBox> columnNames = new Stack<TextBox>();
//    Stack<ComboBox> columnTypes = new Stack<ComboBox>();


//    public TableColumnsFrom()
//    {
//        InitializeComponent();
//    }

//    private void TableColumnsFrom_Load(object sender, EventArgs e)
//    {
//        TextBox t1 = Functions.CreateTextBox(columnNames.Count);
//        ComboBox c1 = Functions.CreateCombo(columnTypes.Count);

//        t1.Location = new Point(50, 10);
//        c1.Location = new Point(500, 10);

//        columnNames.Push(t1);
//        columnTypes.Push(c1);

//        columnsPnl.Controls.Add(t1);
//        columnsPnl.Controls.Add(c1);
//    }

//    private void addBtn_Click(object sender, EventArgs e)
//    {
//        TextBox t1 = Functions.CreateTextBox(columnNames.Count);
//        ComboBox c1 = Functions.CreateCombo(columnTypes.Count);

//        t1.Location = new Point(50, 10 + 30 * columnNames.Count);
//        c1.Location = new Point(500, 10 + 30 * columnNames.Count);

//        columnNames.Push(t1);
//        columnTypes.Push(c1);

//        columnsPnl.Controls.Add(t1);
//        columnsPnl.Controls.Add(c1);
//    }

//    private void rmvBtn_Click(object sender, EventArgs e)
//    {
//        TextBox t1 = columnNames.Pop();
//        ComboBox c1 = columnTypes.Pop();

//        columnsPnl.Controls.Remove(t1);
//        columnsPnl.Controls.Remove(c1);
//    }

//    private void columnsPnl_Paint(object sender, PaintEventArgs e)
//    {

//    }

//    private void button1_Click(object sender, EventArgs e)
//    {
//        Hide();
//        Tables tables = new Tables();
//        tables.ShowDialog();
//        this.Show();

//    }

//    private void SaveBtn_Click(object sender, EventArgs e)
//    {
//        List<string> columnDefinitions = new List<string>();

//        foreach (var t in columnNames.Zip(columnTypes, (textBox, comboBox) => new { textBox, comboBox }))
//        {
//            string columnName = t.textBox.Text;
//            string columnType = t.comboBox.SelectedItem.ToString();

//            if (!string.IsNullOrWhiteSpace(columnName) && !string.IsNullOrWhiteSpace(columnType))
//            {
//                columnDefinitions.Add($"{columnName} {columnType}");
//            }
//        }   

//        // Agar ustunlar mavjud bo'lsa
//        if (columnDefinitions.Count > 0)
//        {
//            // Masalan, SQL jadval yaratish sintaksisi

//             string tableName =$""; // Siz xohlagan jadval nomini o'rnating
//            string createTableQuery = $"CREATE TABLE {tableName} (\n{string.Join(",\n", columnDefinitions)}\n);";

//            // Bu yerda ma'lumotlar bazasiga ulanish va so'rovni bajarish kodini yozish mumkin.
//            // Masalan, Npgsql orqali PostgreSQL bilan ishlash uchun:
//            try
//            {
//                using (var conn = new NpgsqlConnection(Form1.connectionString))
//                {
//                    conn.Open();
//                    using (var cmd = new NpgsqlCommand(createTableQuery, conn))
//                    {
//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                MessageBox.Show("Jadval muvaffaqiyatli saqlandi!");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Xato yuz berdi: {ex.Message}");
//            }
//        }
//        else
//        {
//            MessageBox.Show("Iltimos, kamida bitta ustun qo'shing!");
//        }
//    }

//    private void textBox1_TextChanged(object sender, EventArgs e)
//    {
//       // tableName = textBox1.Text.Trim();
//    }

//}

//***********

using Npgsql;

namespace Query_Visual_Version;

public partial class TableColumnsFrom : Form
{
    Stack<TextBox> columnNames = new Stack<TextBox>();
    Stack<ComboBox> columnTypes = new Stack<ComboBox>();
    private string tableName = "";  // Jadval nomini saqlash uchun o'zgaruvchi

    public TableColumnsFrom()
    {
        InitializeComponent();
    }

    private void TableColumnsFrom_Load(object sender, EventArgs e)
    {
        TextBox t1 = Functions.CreateTextBox(columnNames.Count);
        ComboBox c1 = Functions.CreateCombo(columnTypes.Count);

        t1.Location = new Point(50, 10);
        c1.Location = new Point(500, 10);

        columnNames.Push(t1);
        columnTypes.Push(c1);

        columnsPnl.Controls.Add(t1);
        columnsPnl.Controls.Add(c1);
    }

    private void addBtn_Click(object sender, EventArgs e)
    {
        TextBox t1 = Functions.CreateTextBox(columnNames.Count);
        ComboBox c1 = Functions.CreateCombo(columnTypes.Count);

        t1.Location = new Point(50, 10 + 30 * columnNames.Count);
        c1.Location = new Point(500, 10 + 30 * columnNames.Count);

        columnNames.Push(t1);
        columnTypes.Push(c1);

        columnsPnl.Controls.Add(t1);
        columnsPnl.Controls.Add(c1);
    }

    private void rmvBtn_Click(object sender, EventArgs e)
    {
        TextBox t1 = columnNames.Pop();
        ComboBox c1 = columnTypes.Pop();

        columnsPnl.Controls.Remove(t1);
        columnsPnl.Controls.Remove(c1);
    }

    private void columnsPnl_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Hide();
        Tables tables = new Tables();
        tables.ShowDialog();
        this.Show();
    }

    // Bu funksiya textBox1 ichidagi jadval nomini saqlaydi
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        tableName = textBox1.Text.Trim();  // Jadval nomini olish va bo'sh joylardan tozalash
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        List<string> columnDefinitions = new List<string>();

        foreach (var t in columnNames.Zip(columnTypes, (textBox, comboBox) => new { textBox, comboBox }))
        {
            string columnName = t.textBox.Text;
            string columnType = t.comboBox.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(columnName) && !string.IsNullOrWhiteSpace(columnType))
            {
                columnDefinitions.Add($"{columnName} {columnType}");
            }
        }

        if (columnDefinitions.Count > 0 && !string.IsNullOrWhiteSpace(tableName))
        {
            string createTableQuery = $"CREATE TABLE {tableName} (\n{string.Join(",\n", columnDefinitions)}\n);";

            try
            {
                using (var conn = new NpgsqlConnection(Form1.connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Jadval muvaffaqiyatli saqlandi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xato yuz berdi: {ex.Message}");
            }
        }
        else if (string.IsNullOrWhiteSpace(tableName))
        {
            MessageBox.Show("Iltimos, jadval nomini kiriting!");
        }
        else
        {
            MessageBox.Show("Iltimos, kamida bitta ustun qo'shing!");
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        
    }
}


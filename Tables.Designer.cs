
namespace Query_Visual_Version
{
    partial class Tables
    {
        public static string SelectedTable()
        {
            return comboBox1.SelectedItem?.ToString();
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            addTableBtn = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(187, 336);
            button3.Name = "button3";
            button3.Size = new Size(94, 54);
            button3.TabIndex = 2;
            button3.Text = "Update ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(514, 336);
            button4.Name = "button4";
            button4.Size = new Size(94, 54);
            button4.TabIndex = 3;
            button4.Text = "Drop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(187, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // addTableBtn
            // 
            addTableBtn.Location = new Point(51, 336);
            addTableBtn.Name = "addTableBtn";
            addTableBtn.Size = new Size(94, 54);
            addTableBtn.TabIndex = 5;
            addTableBtn.Text = "Add Table";
            addTableBtn.UseVisualStyleBackColor = true;
            addTableBtn.Click += addTableBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 6;
            label1.Text = "Table List";
            // 
            // button1
            // 
            button1.Location = new Point(51, 445);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(353, 336);
            button2.Name = "button2";
            button2.Size = new Size(94, 54);
            button2.TabIndex = 8;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Tables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 503);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(addTableBtn);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "Tables";
            Text = "Tables";
            Load += Tables_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            string selectedTable = comboBox1.SelectedItem?.ToString();
            // Tanlangan jadvalni comboBox1 dan olish

            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Iltimos, jadval tanlang.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yangilash oynasini ochish
            UpdateTableFrom updateForm = new UpdateTableFrom();
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                // Foydalanuvchi kiritgan ma'lumotlarni olish
                string columnName = updateForm.ColumnName;
                string newValue = updateForm.NewValue;
                string condition = updateForm.Condition;

                // Bo'sh maydonlarni tekshirish
                if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(newValue) || string.IsNullOrEmpty(condition))
                {
                    MessageBox.Show("Iltimos, barcha maydonlarni to'ldiring.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SQL so'rovini yaratish
                string query = $"UPDATE {selectedTable} SET {columnName} = @NewValue WHERE {condition}";

                using (var connection = new Npgsql.NpgsqlConnection("your_connection_string"))
                {
                    using (var command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewValue", newValue);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show($"{rowsAffected} qator yangilandi.", "Yangilash muvaffaqiyatli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Xato: {ex.Message}", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        #endregion
        private Button button3;
        private Button button4;
        private Button addTableBtn;
        private Label label1;
        private Button button1;
        private Button button2;
        public static ComboBox comboBox1;
    }
}
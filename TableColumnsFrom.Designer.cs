namespace Query_Visual_Version
{
    partial class TableColumnsFrom
    {
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
            label1 = new Label();
            columnsPnl = new Panel();
            addBtn = new Button();
            rmvBtn = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Table Name";
            // 
            // columnsPnl
            // 
            columnsPnl.BorderStyle = BorderStyle.FixedSingle;
            columnsPnl.Location = new Point(12, 97);
            columnsPnl.Name = "columnsPnl";
            columnsPnl.Size = new Size(776, 300);
            columnsPnl.TabIndex = 1;
            columnsPnl.Paint += columnsPnl_Paint;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(202, 409);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(115, 29);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add Column";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // rmvBtn
            // 
            rmvBtn.Location = new Point(422, 409);
            rmvBtn.Name = "rmvBtn";
            rmvBtn.Size = new Size(134, 29);
            rmvBtn.TabIndex = 3;
            rmvBtn.Text = "Remove Column";
            rmvBtn.UseVisualStyleBackColor = true;
            rmvBtn.Click += rmvBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(634, 409);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // TableColumnsFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveBtn);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(rmvBtn);
            Controls.Add(addBtn);
            Controls.Add(columnsPnl);
            Controls.Add(label1);
            Name = "TableColumnsFrom";
            Text = "TableColumnsFrom";
            Load += TableColumnsFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel columnsPnl;
        private Button addBtn;
        private Button rmvBtn;
        private Button button1;
        private TextBox textBox1;
        private Button SaveBtn;
    }
}
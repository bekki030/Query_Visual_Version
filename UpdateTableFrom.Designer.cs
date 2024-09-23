namespace Query_Visual_Version
{
    partial class UpdateTableFrom
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
            label2 = new Label();
            label3 = new Label();
            txtColumnName = new TextBox();
            txtNewValue = new TextBox();
            txtCondition = new TextBox();
            btnUpdate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 65);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Column Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 127);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "New Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 192);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Condition";
            // 
            // txtColumnName
            // 
            txtColumnName.Location = new Point(244, 58);
            txtColumnName.Name = "txtColumnName";
            txtColumnName.Size = new Size(258, 27);
            txtColumnName.TabIndex = 3;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(244, 127);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(258, 27);
            txtNewValue.TabIndex = 4;
            // 
            // txtCondition
            // 
            txtCondition.Location = new Point(244, 192);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(258, 27);
            txtCondition.TabIndex = 5;
            txtCondition.TextChanged += txtCondition_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(605, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(60, 347);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateTableFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(txtCondition);
            Controls.Add(txtNewValue);
            Controls.Add(txtColumnName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateTableFrom";
            Text = "UpdateTableFrom";
            Load += UpdateTableFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtColumnName;
        private TextBox txtNewValue;
        private TextBox txtCondition;
        private Button btnUpdate;
        private Button button1;
    }
}
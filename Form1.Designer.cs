﻿namespace Query_Visual_Version
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHost = new TextBox();
            txtPort = new TextBox();
            txtDatabase = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 54);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter ConnectionString";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 126);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Host";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 187);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 251);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "DataBase";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 312);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "User Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 379);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(253, 119);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(233, 27);
            txtHost.TabIndex = 6;
            txtHost.TextChanged += txtHost_TextChanged;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(253, 187);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(233, 27);
            txtPort.TabIndex = 7;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(253, 251);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(233, 27);
            txtDatabase.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(253, 312);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(233, 27);
            txtUserName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(253, 376);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(233, 27);
            txtPassword.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(647, 379);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtDatabase);
            Controls.Add(txtPort);
            Controls.Add(txtHost);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHost;
        private TextBox txtPort;
        private TextBox txtDatabase;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button1;
    }
}

namespace Lapura_LA2
{
    partial class DetailsPage
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
            mainPanel = new Panel();
            Result = new Label();
            BackBtn = new Button();
            SubmitBtn = new Button();
            Email = new TextBox();
            Age = new TextBox();
            label2 = new Label();
            label1 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(240, 245, 249);
            mainPanel.Controls.Add(Result);
            mainPanel.Controls.Add(BackBtn);
            mainPanel.Controls.Add(SubmitBtn);
            mainPanel.Controls.Add(Email);
            mainPanel.Controls.Add(Age);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(40);
            mainPanel.Size = new Size(800, 450);
            mainPanel.TabIndex = 0;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Segoe UI", 10F);
            Result.ForeColor = Color.FromArgb(0, 64, 128);
            Result.Location = new Point(201, 334);
            Result.Name = "Result";
            Result.Size = new Size(0, 28);
            Result.TabIndex = 6;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(100, 130, 160);
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(201, 274);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(110, 45);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click_1;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(0, 32, 63);
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(331, 274);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(150, 45);
            SubmitBtn.TabIndex = 4;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // Email
            // 
            Email.BackColor = Color.White;
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Font = new Font("Segoe UI", 10F);
            Email.Location = new Point(331, 211);
            Email.Name = "Email";
            Email.Size = new Size(250, 34);
            Email.TabIndex = 3;
            // 
            // Age
            // 
            Age.BackColor = Color.White;
            Age.BorderStyle = BorderStyle.FixedSingle;
            Age.Font = new Font("Segoe UI", 10F);
            Age.Location = new Point(331, 151);
            Age.Name = "Age";
            Age.Size = new Size(250, 34);
            Age.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 32, 63);
            label2.Location = new Point(201, 214);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 32, 63);
            label1.Location = new Point(201, 154);
            label1.Name = "label1";
            label1.Size = new Size(53, 28);
            label1.TabIndex = 0;
            label1.Text = "Age:";
            // 
            // DetailsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DetailsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details Page";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Label label2;
        private TextBox Age;
        private TextBox Email;
        private Button SubmitBtn;
        private Button BackBtn;
        private Label Result;
    }
}
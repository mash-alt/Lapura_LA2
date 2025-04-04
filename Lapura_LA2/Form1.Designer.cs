namespace Lapura_LA2
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
            mainPanel = new Panel();
            button1 = new Button();
            Result = new Label();
            Submit = new Button();
            LastName = new TextBox();
            FirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(240, 245, 249);
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(Result);
            mainPanel.Controls.Add(Submit);
            mainPanel.Controls.Add(LastName);
            mainPanel.Controls.Add(FirstName);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(40);
            mainPanel.Size = new Size(800, 450);
            mainPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 32, 63);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(431, 274);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Segoe UI", 10F);
            Result.ForeColor = Color.FromArgb(0, 64, 128);
            Result.Location = new Point(201, 334);
            Result.Name = "Result";
            Result.Size = new Size(0, 28);
            Result.TabIndex = 2;
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(0, 32, 63);
            Submit.Cursor = Cursors.Hand;
            Submit.FlatAppearance.BorderSize = 0;
            Submit.FlatStyle = FlatStyle.Flat;
            Submit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Submit.ForeColor = Color.White;
            Submit.Location = new Point(201, 274);
            Submit.Name = "Submit";
            Submit.Size = new Size(150, 45);
            Submit.TabIndex = 5;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // LastName
            // 
            LastName.BackColor = Color.White;
            LastName.BorderStyle = BorderStyle.FixedSingle;
            LastName.Font = new Font("Segoe UI", 10F);
            LastName.Location = new Point(331, 211);
            LastName.Name = "LastName";
            LastName.Size = new Size(250, 34);
            LastName.TabIndex = 4;
            // 
            // FirstName
            // 
            FirstName.BackColor = Color.White;
            FirstName.BorderStyle = BorderStyle.FixedSingle;
            FirstName.Font = new Font("Segoe UI", 10F);
            FirstName.Location = new Point(331, 151);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(250, 34);
            FirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 32, 63);
            label2.Location = new Point(201, 214);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 32, 63);
            label1.Location = new Point(201, 154);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Information System";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanel;
        private Label label1;
        private Label label2;
        private Label Result;
        private TextBox FirstName;
        private TextBox LastName;
        private Button Submit;
        private Button button1;
    }
}
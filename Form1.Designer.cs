namespace LoginScreen
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
            textBox_pwd = new TextBox();
            textBox_id = new TextBox();
            lbl_Login = new Label();
            btn_login = new Button();
            lbl_Fail = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_pwd
            // 
            textBox_pwd.Dock = DockStyle.Fill;
            textBox_pwd.Location = new Point(3, 156);
            textBox_pwd.Name = "textBox_pwd";
            textBox_pwd.PlaceholderText = "비밀번호";
            textBox_pwd.Size = new Size(377, 27);
            textBox_pwd.TabIndex = 0;
            textBox_pwd.UseSystemPasswordChar = true;
            textBox_pwd.KeyDown += textBox_pwd_KeyDown;
            // 
            // textBox_id
            // 
            textBox_id.Dock = DockStyle.Fill;
            textBox_id.Location = new Point(3, 101);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "아이디";
            textBox_id.Size = new Size(377, 27);
            textBox_id.TabIndex = 1;
            textBox_id.KeyDown += textBox_id_KeyDown;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Dock = DockStyle.Fill;
            lbl_Login.Font = new Font("맑은 고딕", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl_Login.Location = new Point(3, 0);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(377, 98);
            lbl_Login.TabIndex = 2;
            lbl_Login.Text = "Login";
            lbl_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Dock = DockStyle.Fill;
            btn_login.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_login.ForeColor = Color.DodgerBlue;
            btn_login.Location = new Point(3, 267);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(377, 127);
            btn_login.TabIndex = 3;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_Fail
            // 
            lbl_Fail.AutoSize = true;
            lbl_Fail.Dock = DockStyle.Fill;
            lbl_Fail.ForeColor = Color.Red;
            lbl_Fail.Location = new Point(3, 213);
            lbl_Fail.Name = "lbl_Fail";
            lbl_Fail.Size = new Size(377, 51);
            lbl_Fail.TabIndex = 4;
            lbl_Fail.Text = "아이디 혹은 비밀번호가 맞지 않습니다.";
            lbl_Fail.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Fail.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbl_Login, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_id, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_Fail, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_login, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox_pwd, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.Size = new Size(383, 397);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 397);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Login Screen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_pwd;
        private TextBox textBox_id;
        private Label lbl_Login;
        private Button btn_login;
        private Label lbl_Fail;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

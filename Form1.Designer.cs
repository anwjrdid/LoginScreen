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
            SuspendLayout();
            // 
            // textBox_pwd
            // 
            textBox_pwd.Location = new Point(24, 149);
            textBox_pwd.Name = "textBox_pwd";
            textBox_pwd.PlaceholderText = "비밀번호";
            textBox_pwd.Size = new Size(292, 27);
            textBox_pwd.TabIndex = 0;
            textBox_pwd.UseSystemPasswordChar = true;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(24, 93);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "아이디";
            textBox_id.Size = new Size(292, 27);
            textBox_id.TabIndex = 1;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Font = new Font("맑은 고딕", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl_Login.Location = new Point(88, 9);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(173, 72);
            lbl_Login.TabIndex = 2;
            lbl_Login.Text = "Login";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_login.ForeColor = Color.DodgerBlue;
            btn_login.Location = new Point(88, 208);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(159, 67);
            btn_login.TabIndex = 3;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_Fail
            // 
            lbl_Fail.AutoSize = true;
            lbl_Fail.ForeColor = Color.Red;
            lbl_Fail.Location = new Point(33, 179);
            lbl_Fail.Name = "lbl_Fail";
            lbl_Fail.Size = new Size(272, 20);
            lbl_Fail.TabIndex = 4;
            lbl_Fail.Text = "아이디 혹은 비밀번호가 맞지 않습니다.";
            lbl_Fail.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 313);
            Controls.Add(lbl_Fail);
            Controls.Add(btn_login);
            Controls.Add(lbl_Login);
            Controls.Add(textBox_id);
            Controls.Add(textBox_pwd);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_pwd;
        private TextBox textBox_id;
        private Label lbl_Login;
        private Button btn_login;
        private Label lbl_Fail;
    }
}

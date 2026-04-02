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
            Login_lbl = new Label();
            btn_login = new Button();
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
            // Login_lbl
            // 
            Login_lbl.AutoSize = true;
            Login_lbl.Font = new Font("맑은 고딕", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Login_lbl.Location = new Point(88, 9);
            Login_lbl.Name = "Login_lbl";
            Login_lbl.Size = new Size(173, 72);
            Login_lbl.TabIndex = 2;
            Login_lbl.Text = "Login";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 313);
            Controls.Add(btn_login);
            Controls.Add(Login_lbl);
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
        private Label Login_lbl;
        private Button btn_login;
    }
}

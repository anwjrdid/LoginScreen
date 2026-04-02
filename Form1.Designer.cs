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
            components = new System.ComponentModel.Container();
            txtPW = new TextBox();
            txtID = new TextBox();
            lblAppName = new Label();
            btnLogin = new Button();
            lbl_Fail = new Label();
            chkShowPW = new CheckBox();
            btnClear = new Button();
            loginTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 15F);
            txtPW.Location = new Point(33, 172);
            txtPW.Name = "txtPW";
            txtPW.PlaceholderText = "비밀번호";
            txtPW.Size = new Size(336, 41);
            txtPW.TabIndex = 2;
            txtPW.UseSystemPasswordChar = true;
            txtPW.KeyDown += textBox_pwd_KeyDown;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 15F);
            txtID.Location = new Point(33, 84);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "아이디";
            txtID.Size = new Size(336, 41);
            txtID.TabIndex = 1;
            txtID.KeyDown += textBox_id_KeyDown;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(118, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(173, 72);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = Color.DodgerBlue;
            btnLogin.Location = new Point(33, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 104);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btn_login_Click;
            // 
            // lbl_Fail
            // 
            lbl_Fail.AutoSize = true;
            lbl_Fail.ForeColor = Color.Red;
            lbl_Fail.Location = new Point(69, 222);
            lbl_Fail.Name = "lbl_Fail";
            lbl_Fail.Size = new Size(272, 20);
            lbl_Fail.TabIndex = 6;
            lbl_Fail.Text = "아이디 혹은 비밀번호가 맞지 않습니다.";
            lbl_Fail.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Fail.Visible = false;
            // 
            // chkShowPW
            // 
            chkShowPW.AutoSize = true;
            chkShowPW.Location = new Point(273, 144);
            chkShowPW.Name = "chkShowPW";
            chkShowPW.Size = new Size(96, 24);
            chkShowPW.TabIndex = 5;
            chkShowPW.Text = "비번 확인";
            chkShowPW.UseVisualStyleBackColor = true;
            chkShowPW.CheckedChanged += chkShowPW_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MistyRose;
            btnClear.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.ForeColor = Color.Crimson;
            btnClear.Location = new Point(209, 245);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 98);
            btnClear.TabIndex = 4;
            btnClear.Text = "삭제";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // loginTimer
            // 
            loginTimer.Interval = 1000;
            loginTimer.Tick += loginTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 380);
            Controls.Add(lblAppName);
            Controls.Add(txtID);
            Controls.Add(btnClear);
            Controls.Add(txtPW);
            Controls.Add(lbl_Fail);
            Controls.Add(chkShowPW);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPW;
        private TextBox txtID;
        private Label lblAppName;
        private Button btnLogin;
        private Label lbl_Fail;
        private CheckBox chkShowPW;
        private Button btnClear;
        private System.Windows.Forms.Timer loginTimer;
    }
}

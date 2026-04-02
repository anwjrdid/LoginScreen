using System;
using System.Windows.Forms;
using System.Text.RegularExpressions; // 특수문자 체크를 위해 필요

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 시작할 때 비밀번호 가리기
            txtPW.UseSystemPasswordChar = true;
        }

        int loginFailCount = 0; // 실패 횟수
        int lockTime = 10;      // 잠금 시간(초)

        private void btn_login_Click(object sender, EventArgs e)
        {
            string myID = "suwon@suwon.ac.kr";
            string myPW = "suwon123!"; // 예시 정답 (특수문자 포함)

            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            // 1. 공백 확인
            if (string.IsNullOrWhiteSpace(inputID) || string.IsNullOrWhiteSpace(inputPW))
            {
                lbl_Fail.Text = "아이디와 비밀번호를 모두 입력해주세요.";
                lbl_Fail.Visible = true;
                return;
            }

            // 2. 비밀번호 유효성 검사 (8자 이상, 숫자와 특수문자 필수)
            if (!IsPasswordValid(inputPW))
            {
                lbl_Fail.Text = "PW는 8자 이상, 숫자와 특수문자를 포함해야 합니다.";
                lbl_Fail.Visible = true;
                return;
            }

            // 3. 로그인 판별
            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 성공!", "알림");
                loginFailCount = 0;
                lbl_Fail.Visible = false;
            }
            else
            {
                loginFailCount++;

                // 4. 시도 제한 및 타이머 실행
                if (loginFailCount >= 3)
                {
                    btnLogin.Enabled = false; // 버튼 잠금
                    loginTimer.Start();       // 타이머 시작
                    lbl_Fail.Text = $"{lockTime}초 후 다시 시도하세요. (3회 실패)";
                }
                else
                {
                    lbl_Fail.Text = $"정보가 틀렸습니다. ({loginFailCount}/3)";
                }
                lbl_Fail.Visible = true;
            }
        }

        // 비밀번호 형식 체크 메서드
        private bool IsPasswordValid(string pw)
        {
            bool hasMinLen = pw.Length >= 8;
            bool hasNum = Regex.IsMatch(pw, @"[0-9]");
            bool hasSpecial = Regex.IsMatch(pw, @"[!@#$%^&*]");
            return hasMinLen && hasNum && hasSpecial;
        }

        // 타이머 이벤트 (1초마다 실행)
        private void loginTimer_Tick(object sender, EventArgs e)
        {
            lockTime--;
            lbl_Fail.Text = $"보안 잠금 중... {lockTime}초 남음";

            if (lockTime <= 0)
            {
                loginTimer.Stop();
                btnLogin.Enabled = true; // 버튼 다시 활성화
                loginFailCount = 0;      // 횟수 초기화
                lockTime = 10;           // 시간 초기화
                lbl_Fail.Text = "다시 시도할 수 있습니다.";
            }
        }

        // --- 기타 기능 (엔터키, 지우기, 비번보기) ---
        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; txtPW.Focus(); }
        }

        private void textBox_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnLogin.PerformClick(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear(); txtPW.Clear(); lbl_Fail.Visible = false; txtID.Focus();
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = !chkShowPW.Checked;
        }
    }
}
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
            string myID = "admin";
            string myPW = "superman123!"; // 예시 정답 (특수문자 포함)

            string inputID = txtID.Text; // 입력된 아이디
            string inputPW = txtPW.Text; // 입력된 비밀번호

            // 1. 공백 확인
            if (string.IsNullOrWhiteSpace(inputID) || string.IsNullOrWhiteSpace(inputPW))
            {
                lbl_Fail.Text = "아이디와 비밀번호를 모두 입력해주세요.";
                lbl_Fail.Visible = true; // 실패 메시지 표시
                return;
            }

            // 2. 비밀번호 유효성 검사 (8자 이상, 숫자와 특수문자 필수)
            if (!IsPasswordValid(inputPW))
            {
                lbl_Fail.Text = "PW는 8자 이상, 숫자와 특수문자를 포함해야 합니다.";
                lbl_Fail.Visible = true;  // 실패 메시지 표시
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
                loginFailCount++;  // 실패 횟수 증가

                // 4. 시도 제한 및 타이머 실행 (점진적 증가 로직 적용)
                if (loginFailCount >= 3)
                {
                    // 실패 횟수에 따라 잠금 시간 설정
                    if (loginFailCount == 3) lockTime = 10;
                    else if (loginFailCount == 4) lockTime = 30;
                    else lockTime = 60; // 5회 이상 실패 시 60초 고정

                    btnLogin.Enabled = false; // 버튼 잠금
                    loginTimer.Start();       // 타이머 시작
                    lbl_Fail.Text = $"{lockTime}초 후 다시 시도하세요. (누적 실패: {loginFailCount}회)";
                }
                else
                {
                    lbl_Fail.Text = $"정보가 틀렸습니다. ({loginFailCount}/3)";  // 실패 메시지 표시
                }
                lbl_Fail.Visible = true;
            }
        }

        // 비밀번호 형식 체크 메서드
        private bool IsPasswordValid(string pw)
        {
            bool hasMinLen = pw.Length >= 8;
            bool hasNum = Regex.IsMatch(pw, @"[0-9]"); // 숫자 체크
            bool hasSpecial = Regex.IsMatch(pw, @"[!@#$%^&*]"); // 특수문자 체크 (필요에 따라 추가 가능)
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

                // 점진적 증가를 유지하기 위해 loginFailCount는 초기화하지 않음 (로그인 성공 시에만 초기화)
                // lockTime은 다음 잠금을 위해 기본값으로 리셋
                lockTime = 10;
                lbl_Fail.Text = "다시 시도할 수 있습니다."; // 메시지 업데이트
            }
        }

        // --- 기타 기능 (엔터키, 지우기, 비번보기) ---
        private void textBox_id_KeyDown(object sender, KeyEventArgs e) // 아이디 입력창에서 엔터키
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; txtPW.Focus(); } // 엔터키 입력 시 비밀번호 입력창으로 포커스 이동
        }

        private void textBox_pwd_KeyDown(object sender, KeyEventArgs e) // 비밀번호 입력창에서 엔터키
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnLogin.PerformClick(); } // 엔터키 입력 시 로그인 버튼 클릭 이벤트 실행
        }

        private void btnClear_Click(object sender, EventArgs e) // 지우기 버튼
        {
            txtID.Clear(); txtPW.Clear(); lbl_Fail.Visible = false; txtID.Focus();
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e) // 비밀번호 보기 체크박스
        {
            txtPW.UseSystemPasswordChar = !chkShowPW.Checked;
        }
    }
}
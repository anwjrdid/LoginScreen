namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int loginFailCount = 0; // 로그인 실패 횟수를 저장하는 변수
        private void btn_login_Click(object sender, EventArgs e)
        {
            string myID = "suwon";
            string myPW = "1234";
            string inputID = textBox_id.Text;
            string inputPW = textBox_pwd.Text;

            // 1. 입력 문자 검증 (예: 공백 체크)
            if (string.IsNullOrWhiteSpace(inputID) || string.IsNullOrWhiteSpace(inputPW))
            {
                lbl_Fail.Text = "아이디와 비밀번호를 모두 입력해주세요.";
                lbl_Fail.Visible = true;
                return; // 로직 중단
            }

            // 2. 로그인 성공/실패 판별
            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 성공!", "알림");
                loginFailCount = 0; // 성공 시 횟수 초기화
                lbl_Fail.Visible = false;
            }
            else
            {
                loginFailCount++; // 실패 횟수 증가

                // 3. 실패 횟수에 따른 처리
                if (loginFailCount >= 3)
                {
                    lbl_Fail.Text = "3회 이상 실패! 더 이상 로그인할 수 없습니다.";
                    btn_login.Enabled = false; // 버튼 비활성화
                }
                else
                {
                    lbl_Fail.Text = $"아이디 또는 비밀번호가 틀렸습니다. ({loginFailCount}/3)";
                }
                lbl_Fail.Visible = true;
            }
        }

        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter 키가 눌렸는지 확인
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // '띵' 하는 비프음 방지
                textBox_pwd.Focus(); // 패스워드 입력창으로 포커스 이동
            }
        }

        private void textBox_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 비프음 방지
                btn_login.PerformClick(); // 로그인 버튼을 클릭한 것처럼 동작
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();   // 아이디 칸 비우기
            textBox_pwd.Clear();  // 패스워드 칸 비우기
            lbl_Fail.Visible = false; // 표시되어 있던 에러 메시지도 숨기기
            textBox_id.Focus();   // 다시 입력을 시작할 수 있게 아이디 칸으로 포커스 이동
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPW.Checked)
            {
                textBox_pwd.UseSystemPasswordChar = false; // 글자 보이게
            }
            else
            {
                textBox_pwd.UseSystemPasswordChar = true;  // 글자 숨기게 (● 표시)
            }
        }
    }
}

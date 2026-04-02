namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string myID = "suwon";
            string myPW = "123456";

            string inputID = textBox_id.Text;
            string inputPW = textBox_pwd.Text;

            if (inputID == myID && inputPW == myPW)
            {
                // 로그인 성공 시
                MessageBox.Show("로그인 성공!");
                lbl_Fail.Visible = false; // 에러 메시지 숨기기
            }
            else
            {
                // 로그인 실패 시 (메시지 박스 대신 라벨 사용)
                lbl_Fail.Visible = true; // 에러 메시지 보여주기
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

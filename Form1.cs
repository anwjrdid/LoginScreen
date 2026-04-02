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
            // 실제 정답 정보 (강의 예시 기준)
            string myID = "sungmin";
            string myPW = "superman";

            // 사용자가 입력한 값 가져오기
            string inputID = textBox_id.Text;
            string inputPW = textBox_pwd.Text;

            // 조건문을 통한 로그인 체크
            if (inputID == myID && inputPW == myPW)
            {
                // 성공 시 메시지 박스 출력
                MessageBox.Show("로그인 성공!", "로그인", MessageBoxButtons.OK);
            }
            else
            {
                // 실패 시 에러 아이콘과 함께 출력
                MessageBox.Show("로그인 실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

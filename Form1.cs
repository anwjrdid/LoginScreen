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
    }
}

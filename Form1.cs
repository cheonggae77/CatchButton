using System.Runtime.CompilerServices;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 점수 저장용 필드 추가
        private int score = 0;
        private int title1 = 0;
        private int title2 = 0;
        private int count1 = 0;
        private string originalText; // 버튼의 원래 텍스트를 저장할 필드
        public Form1()
        {
            InitializeComponent();
            // 초기 제목 표시
            titlename();
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent; // 클릭 시 색상 방지
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent; // 마우스 올릴 때 색상 방지
            originalText = button1.Text;
            button1.Text = ""; // 빈 칸으로 만듦
        }

        private void titlename()
        {
            this.Text = $"버튼 위치 : ({title1}, {title2}) | 점수 : {score}";
        }

        private void running_button_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수 생성기 준비
            Random rd = new Random();
            // 2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width - running_button.Size.Width;
            int maxY = this.ClientSize.Height - running_button.Size.Height;
            // 3. 랜덤 좌표 추출 (0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치 할당 (새로운 Point 객체 생성)
            running_button.Location = new Point(nextX, nextY);

            // 실제 버튼이 이동한 좌표를 제목에 표시하도록 수정
            title1 = nextX;
            title2 = nextY;
            score = score - 10;
            count1++;
            titlename();
            if (count1 == 20)
            {
                MessageBox.Show("Game Over");
                running_button.Enabled = false;
                button1.Text = originalText;
                button1.Enabled = true;
                button1.FlatStyle = FlatStyle.Standard;
            }
        }

        private void running_button_Click(object sender, EventArgs e)
        {
            // 버튼을 잡을 때마다 점수 증가

            MessageBox.Show("축하합니다~!");

            score = score + 100;
            count1 = 0;
            // 폼 제목에 점수 표시
            titlename();
            if (count1 == 20)
            {
                MessageBox.Show("Game Over");
                running_button.Enabled = false;
                button1.Text = originalText;
                button1.Enabled = true;
                button1.FlatStyle = FlatStyle.Standard;
            }
            running_button.Width = (int)(running_button.Width * 0.9);
            running_button.Height = (int)(running_button.Height * 0.9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            title1 = 0;
            title2 = 0;
            count1 = 0;
            running_button.Enabled = true; 
            running_button.Location = new Point(260, 141);
            running_button.Width = 300; 
            running_button.Height = 150;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent; // 클릭 시 색상 방지
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent; // 마우스 올릴 때 색상 방지
            originalText = button1.Text;
            button1.Text = ""; // 빈 칸으로 만듦
            titlename();
        }
    }
}

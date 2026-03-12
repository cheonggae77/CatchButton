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

        public Form1()
        {
            InitializeComponent();
            // 초기 제목 표시
            titlename();
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

            }
        }

        private void running_button_Click(object sender, EventArgs e)
        {
            // 버튼을 잡을 때마다 점수 증가
            
            MessageBox.Show("축하합니다~!");

            score = score + 100;
            // 폼 제목에 점수 표시
            titlename();
            running_button.Width = (int)(running_button.Width * 0.9);
            running_button.Height = (int)(running_button.Height * 0.9);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GomokGameProject
{
    public partial class SinglePlayForm : Form
    {
        private const int rectSize = 33; // 오목판의 셀의 크기(네모 크기)  
        private const int edgeCount = 15; // 오목판의 선 개수 

        private enum Horse { none = 0, BLACK, WHITE };  //흑돌, 백돌
        private Horse[,] board = new Horse[edgeCount, edgeCount];
        private Horse nowPlayer = Horse.BLACK;

        private bool playing = false; 

        public SinglePlayForm()
        {
            InitializeComponent(); //component 불러오기(실행)
        }

        private bool judge() // 승리 판정 함수
        {
            for (int i = 0; i < edgeCount - 4; i++) // 가로로 오목이 됐을 경우 
                for (int j = 0; j < edgeCount; j++) // j를 0에서 부터 시작해서 한칸씩 늘려감(오목판에서 한줄씩 내려감)
                    if (board[i, j] == nowPlayer && board[i + 1, j] == nowPlayer && board[i + 2, j] == nowPlayer && board[i + 3, j] == nowPlayer && board[i + 4, j] == nowPlayer) //가로쪽으로 플레이어의 돌이 5개연속 붙어있으면 
                        return true; //true(1)값을 반환

            for (int i = 0; i < edgeCount; i++) // 세로로 오목이 됐을 경우 
                for (int j = 4; j < edgeCount; j++) // j를 4에서 부터 시작해서 한칸씩 늘려감(오목판에서 한줄씩 내려감)
                    if (board[i, j] == nowPlayer && board[i, j - 1] == nowPlayer && board[i, j - 2] == nowPlayer && board[i, j - 3] == nowPlayer && board[i, j - 4] == nowPlayer) //세로쪽으로 플레이어의 돌이 5개연속 붙어있으면
                        return true; //true(1)값을 반환

            for (int i = 0; i < edgeCount - 4; i++) // Y = X 직선 ( 대각선 ) 
                for (int j = 0; j < edgeCount - 4; j++) //j를 0에서 부터 시작해서 한칸씩 늘려감(오목판에서 한줄씩 내려감)
                    if (board[i, j] == nowPlayer && board[i + 1, j+ 1] == nowPlayer && board[i + 2, j + 2] == nowPlayer && board[i + 3, j + 3] == nowPlayer && board[i + 4, j + 4] == nowPlayer) // 우상향 대각선쪽으로 플레이어의 돌이 5개연속 붙어있으면
                        return true; // true(1)값을 반환

            for (int i = 4; i < edgeCount; i++) // Y = - X 직선 ( 대각선 반대 ) 
                for (int j = 0; j < edgeCount - 4; j++) // j를 0에서 부터 시작해서 한칸씩 늘려감(오목판에서 한줄씩 내려감)
                    if (board[i, j] == nowPlayer && board[i - 1, j + 1] == nowPlayer && board[i - 2, j + 2] == nowPlayer && board[i - 3, j + 3] == nowPlayer && board[i - 4, j + 4] == nowPlayer) // 우하향 대각선쪽으로 플레이어의 돌이 5개연속 붙어있으면
                        return true; //true(1)값을 반환

            return false; // 필수 
        }

        private void refresh() 
        {
            this.boardPicture.Refresh();
            for (int i = 0; i < edgeCount; i++)
                for (int j = 0; j < edgeCount; j++)
                    board[i, j] = Horse.none; 
        }

        private void boardPicture_MouseDown(object sender, MouseEventArgs e) // 오목판을 클릭했을 떄 
        {
            if (!playing) // 플레이중이 아니면 실행 
            {
                MessageBox.Show("게임을 실행해주세요"); //문구가 뜸
                return; 
            }
            Graphics g = this.boardPicture.CreateGraphics(); // 그림 그리기 위한 그래픽스 개체 
            int x = e.X / rectSize; // 사용자가 클릭한 위치가 몇번째 셀인지 확인 
            int y = e.Y / rectSize; // 사용자가 클릭한 위치가 몇번째 셀인지 확인
            if (x < 0 || y < 0 || x >= edgeCount || y >= edgeCount) // 0 ~ 14 미만이거나 초과일 때 x 
            {
                MessageBox.Show("테두리를 벗어날 수 없습니다."); //문구가 뜸
                return;
            }
            MessageBox.Show(x + "," + y); // 현재 셀의 위치
                                          // 

            if (board[x, y] != Horse.none) return;
            board[x, y] = nowPlayer; 
            
            if (nowPlayer == Horse.BLACK)
            {
                SolidBrush brush = new SolidBrush(Color.Black); // 현재 플레이어가 나면 검은색 돌 
                g.FillEllipse(brush, x * rectSize, y * rectSize, rectSize, rectSize); // 원형 그리기 , 좌표, 지름 
            }
            else
            {
                SolidBrush brush = new SolidBrush(Color.White); //현재 플레이어가 내가 아니면 흰 돌
                g.FillEllipse(brush, x * rectSize, y * rectSize, rectSize, rectSize); //원형 그리기, 좌표, 지름
            }

            if (judge()) // 승리하면 실행
            {
                status.Text = nowPlayer.ToString() + "플레이어가 승리했습니다. ";
                playing = false; //playing 값 false 지정
                playButton.Text = "게임시작"; 
            }
            else // 그렇지 않으면 실행
            {
                nowPlayer = ((nowPlayer == Horse.BLACK) ? Horse.WHITE : Horse.BLACK); // 지금 돌이 흑돌이면 다음돌은 백돌로 놓여지고, 백돌이면 흑돌로 놓여짐
                status.Text = nowPlayer.ToString() + "플레이어의 차례입니다. "; 
            }
        }

        private void boardPicture_Paint(object sender, PaintEventArgs e) // 오목판 그리기 
        {
            Graphics gp = e.Graphics;
            Color lineColor = Color.Black; // 오목판의 선 색깔
            Pen p = new Pen(lineColor, 2); //오목판의 선 굵기
            // 전체 오목판 테두리 
            gp.DrawLine(p, rectSize / 2, rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2); // 좌측
            gp.DrawLine(p, rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize / 2); // 상측
            gp.DrawLine(p, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount - rectSize / 2); // 하측
            gp.DrawLine(p, rectSize * edgeCount - rectSize / 2, rectSize / 2, rectSize * edgeCount - rectSize / 2, rectSize * edgeCount - rectSize / 2); // 우측
            p = new Pen(lineColor, 1);
            // 오목판 내부 , 대각선 방향으로 이동하면서 십자가 모양의 선 그리기
            // + 
            //   +
            //     + ... 
            for (int i = rectSize + rectSize / 2; i < rectSize * edgeCount - rectSize / 2; i += rectSize) //오목판 한칸 크기단위로 i값 추가
            {
                gp.DrawLine(p, rectSize / 2, i, rectSize * edgeCount - rectSize / 2, i); //좌측 상단에서 오목판 (한칸+n칸) 크기로 아래로 좌표 이동하며 가로축 선 긋기
                gp.DrawLine(p, i, rectSize / 2, i, rectSize * edgeCount - rectSize / 2); //좌측 상단에서 오목판 (한칸+n칸) 크기로 오른쪽으로 좌표 이동하며 세로축 선 긋기
            }
        }

        private void playButton_Click(object sender, EventArgs e) // 플레이 버튼 클릭
        {
            if (!playing) //플레이중이 아니면 실행 
            {
                refresh(); //새로고침
                playing = true; //플레이중으로 바뀜
                playButton.Text = "재시작";
                status.Text = nowPlayer.ToString() + " 플레이어의 차례입니다. "; 
            }
            else // 그렇지 않으면 실행
            {
                refresh(); //새로고침
                status.Text = "게임이 재시작 되었습니다. "; 
            }
        }
    }
}

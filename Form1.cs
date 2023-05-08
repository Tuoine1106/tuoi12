using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Media;


namespace GG1
{
    public partial class Form1 : Form
    {
        
        private int[,] map; //Mảng 2 chiều map để lưu trữ thông tin về các ô trong trò chơi đánh bài mìn.
        private Button[,] buttons;//Mảng 2 chiều buttons để lưu trữ thông tin về các nút trong giao diện của ứng dụng.
        private int size = 10; //Biến size để lưu trữ kích thước của bàn đánh bài mìn.
        private int mines = 10;//Biến mines để lưu trữ số lượng mìn trong bàn đánh bài mìn.
        private SoundPlayer music;
        private SoundPlayer musicbom = new SoundPlayer("nhacbom.wav");
        private SoundPlayer musicwin = new SoundPlayer("wingame.wav");
        private SoundPlayer musicco = new SoundPlayer("nhacco.wav");
        private int seconds = 0;

        public EventHandler New_Game_Click { get; private set; }

        public Form1()
        {
            InitializeComponent();
            NewGame();
            music = new SoundPlayer("nhacnen.wav");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void NewGame()//sẽ khởi tạo các nút trong giao diện và cài đặt sự kiện cho các nút này.
        //Sau đó, hàm này sẽ tạo ra các ô trong bàn đánh bài mìn và đặt các mìn vào các ô này ngẫu nhiên.
        //Cuối cùng, hàm này sẽ tính toán số lượng mìn xung quanh các ô không có mìn và lưu trữ thông tin này vào các ô này
        {
            
            map = new int[size, size];
            buttons = new Button[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(20, 20);
                    buttons[i, j].Location = new Point(i * 20 + 10, j * 20 + 10);
                    buttons[i, j].MouseDown += new MouseEventHandler(button_MouseDown);
                    this.Controls.Add(buttons[i, j]);
                }
            }
            Random rand = new Random();//tạo ra các mìn trong bàn đánh bài mìn ngẫu nhiên.
            for (int i = 0; i < mines; i++)
            {
                int x = rand.Next(size);
                int y = rand.Next(size);
                if (map[x, y] == -1)//Nếu ô tại vị trí (x, y) đã có mìn
                                    //thì đoạn code này sẽ tiếp tục tạo lại hai số nguyên x và y mới cho đến khi tìm được một ô không có mìn.
                {
                    i--;
                    continue;
                }
                map[x, y] = -1;

            }
            for (int i = 0; i < size; i++)//tính toán số lượng mìn xung quanh các ô không có mìn và lưu trữ thông tin này vào các ô này.
            {
                for (int j = 0; j < size; j++)
                {
                    if (map[i, j] == -1)
                        continue;
                    int count = 0;
                    for (int ii = -1; ii <= 1; ii++)
                    {
                        for (int jj = -1; jj <= 1; jj++)
                        {
                            if (i + ii < 0 || i + ii >= size || j + jj < 0 || j + jj >= size)
                                continue;
                            if (map[i + ii, j + jj] == -1)
                                count++;
                        }
                    }
                    map[i, j] = count;
                }
            }

        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
           
            
            Button button = sender as Button;
            int x = (button.Location.X - 10) / 20;
            int y = (button.Location.Y - 10) / 20;
            if (e.Button == MouseButtons.Left)
            {
                if (map[x, y] == -1)
                {
                    DialogResult result = MessageBox.Show("You lose ! Chicken stuff 😂", "Game over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        NewGame();





                    }
                    else if (result == DialogResult.No)
                    {

                    }
                    musicbom.Play();

                    return;

                }
                else
                {
                    button.Text = map[x, y].ToString();
                    button.Enabled = false;

                    
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                if (e.Clicks % 2 == 0)
                {
                    picCo.Visible = false;
                }
                else
                {
                    picCo.Visible = true;
                }

                musicco.Play();
                
                
            }
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            size = 10;
            mines = 10;
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            size = 15;
            mines = 30;
            NewGame();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            size = 20;
            mines = 50;
            NewGame();
        }

       
        
        

        private void picCo_Click(object sender, EventArgs e)
        {
           
        }

        private void picBom_Click(object sender, EventArgs e)
        {

        }
        private void StartTimer()
        {
            timee.Interval = 1000;
            timee.Tick += new EventHandler(time_Tick);
            timee.Start();
        }
        private void time_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTime.Text = TimeSpan.FromSeconds(seconds).ToString();
        }

        private void ckMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMusic.Checked == true)
            {
                
                music.PlayLooping();
                
            }

            else
            {
                music.Stop();
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}

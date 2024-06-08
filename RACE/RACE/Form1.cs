using System.IO.Compression;
using System.Media;
using System.Numerics;
namespace RACE
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose = false;
        private int countCoins = 0;
        private int totalCountCoins = 0;
        private bool soundEnabled = true;




        public Form1()
        {
            InitializeComponent();
            // Обробник події для маніпулювання мишею
            Road.MouseDown += MouseClickDown;
            Road.MouseUp += MouseClickUp;
            Road.MouseMove += MouseClickMove;
            Road2.MouseDown += MouseClickDown;
            Road2.MouseUp += MouseClickUp;
            Road2.MouseMove += MouseClickMove;
            // Приховування певних кнопок при завантаженні кнопки
            labelLose.Visible = false;
            restartButton.Visible = false;
            KeyPreview = true;
            // Обробники подій для кнопок
            playButton.Click += playButton_Click;
            exitButton.Click += exitButton_Click;
            GoMenuButton.Click += GoMenuButton_Click;
            settingsButton.Click += settingsButton_Click;
            timer.Enabled = false;
            GoMenuButton.Visible = false;
            Player.Left = 420;
            Player.Top = 520;
            labelCoins.Visible = false;
            colorButton.Visible = false;
            settingsButton.Visible = true;
            yesButton.Visible = false;
            noButton.Visible = false;
            exitLabel.Visible = false;
            exitSettingsButton.Visible = false;
            totalCoinsLabel.Visible = true;
            audioButton.Visible = false;
            totalCoinsLabel.Text = "Total Coins:  " + countCoins.ToString();
            Music.PlayMenuMusic(); // Звернення до додатковго класу Music.cs для запуску музики

        }



        // Методи для обробки події миші
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + Road.Top);
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Коли натиснута кнопка Play
        private void playButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            labelLose.Visible = false;
            restartButton.Visible = false;
            exitButton.Visible = false;
            colorButton.Visible = false;
            totalCoinsLabel.Visible = false;
            Racelogo.Visible = false;
            Music.StopMenuMusic();
            if (soundEnabled)
            {
                Music.PlayGameMusic();
            }
            else
            {
                Music.StopGameMusic();
            }



        }
        // Метод для обробки таймеру
        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 10;
            Road.Top += speed;
            Road2.Top += speed;
            int carSpeed = 7;
            trafic1.Top += carSpeed;
            trafic2.Top += carSpeed;
            Coin.Top += speed;
            if (Road.Top >= 650)
            {
                Road.Top = 0;
                Road2.Top = -650;
            }
            if (Coin.Top >= 650)
            {
                Coin.Top = -50;
                Random rand = new Random();
                Coin.Left = rand.Next(150, 560);
            }
            if (trafic1.Top >= 650)
            {
                trafic1.Top = -130;
                Random rand = new Random();
                trafic1.Left = rand.Next(150, 290);
            }
            if (trafic2.Top >= 650)
            {
                trafic2.Top = -400;
                Random rand = new Random();
                trafic2.Left = rand.Next(330, 560);
            }
            if (Player.Bounds.IntersectsWith(trafic1.Bounds) || Player.Bounds.IntersectsWith(trafic2.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                restartButton.Visible = true;
                GoMenuButton.Visible = true;
                lose = true;
                Music.StopGameMusic();
                if (soundEnabled)
                {
                    Music.PlayCrashMusic();
                }
                else
                {
                    Music.StopCrashMusic();
                }


            }
            if (Player.Bounds.IntersectsWith(Coin.Bounds))
            {
                countCoins++;
                labelCoins.Text = "Coins: " + countCoins.ToString();
                totalCountCoins++;
                totalCoinsLabel.Text = "Total Coins: " + totalCountCoins.ToString();
                Coin.Top = -50;
                Random rand = new Random();
                Coin.Left = rand.Next(150, 560);




            }

            playButton.Visible = false;
            settingsButton.Visible = false;
            labelCoins.Visible = true;
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        // Метод обробки керування машинкою
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int SpeedTurn = 10;
            int ForwardSpeed = 15;
            int BackwardSpeed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Player.Left > 150)
                Player.Left -= SpeedTurn;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D && Player.Right < 700))
                Player.Left += SpeedTurn;
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                Player.Top -= ForwardSpeed;
            }

            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && Player.Bottom < 650)
            {
                Player.Top += BackwardSpeed;
            }



        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }
        // Коли натиснута кнопка Restart
        private void restartButton_Click(object sender, EventArgs e)
        {
            trafic1.Top = -130;
            trafic2.Top = -400;
            labelLose.Visible = false;
            restartButton.Visible = false;
            GoMenuButton.Visible = false;
            timer.Enabled = true;
            colorButton.Visible = false;
            lose = false;
            Racelogo.Visible = false;
            countCoins = 0;
            labelCoins.Text = "Coins: " + countCoins.ToString();
            Coin.Top = -500;
            Player.Left = 420;
            Player.Top = 520;
            if (soundEnabled)
            {
                Music.PlayGameMusic();
            }
            else
            {
                Music.StopGameMusic();
            }



        }

        // Коли натиснута кнопка Go Menu
        private void GoMenuButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            playButton.Visible = true;
            exitButton.Visible = true;
            colorButton.Visible = false;
            trafic1.Top = -130;
            trafic2.Top = -400;
            Coin.Top = -500;
            Player.Left = 420;
            Player.Top = 520;
            labelLose.Visible = false;
            restartButton.Visible = false;
            GoMenuButton.Visible = false;
            labelCoins.Visible = false;
            settingsButton.Visible = true;
            countCoins = 0;
            labelCoins.Text = "Coins: " + countCoins.ToString();
            lose = false;
            totalCoinsLabel.Visible = true;
            Racelogo.Visible = true;

            if (soundEnabled)
            {
                Music.PlayMenuMusic();
            }
            else
            {
                Music.StopMenuMusic();
            }

        }
        // Коли натиснута кнопка Exit
        private void exitButton_Click(object sender, EventArgs e)
        {
            yesButton.Visible = true;
            noButton.Visible = true;
            playButton.Visible = false;
            exitButton.Visible = false;
            settingsButton.Visible = false;
            exitLabel.Visible = true;
            totalCoinsLabel.Visible = false;
            Racelogo.Visible = false;
        }
        // Коли натиснута кнопка Color
        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                ChangeMenuColor(selectedColor);
            }
        }
        // Метод обробки зміни кольору для кнопок та міток
        private void ChangeMenuColor(Color color)
        {
            this.BackColor = color;
            playButton.BackColor = color;
            exitButton.BackColor = color;
            GoMenuButton.BackColor = color;
            restartButton.BackColor = color;
            labelCoins.BackColor = color;
            labelLose.BackColor = color;
            colorButton.BackColor = color;
            settingsButton.BackColor = color;
            exitLabel.BackColor = color;
            yesButton.BackColor = color;
            noButton.BackColor = color;
            exitSettingsButton.BackColor = color;
            audioButton.BackColor = color;
            totalCoinsLabel.BackColor = color;
            Racelogo.BackColor = color;
        }
        // Коли натиснута кнопка Settings
        private void settingsButton_Click(object sender, EventArgs e)
        {
            colorButton.Visible = true;
            playButton.Visible = false;
            exitButton.Visible = false;
            restartButton.Visible = false;
            GoMenuButton.Visible = false;
            labelLose.Visible = false;
            labelCoins.Visible = false;
            settingsButton.Visible = false;
            GoMenuButton.Visible = false;
            exitSettingsButton.Visible = true;
            audioButton.Visible = true;
            totalCoinsLabel.Visible = false;


        }
        // Коли натиснута кнопка Yes(вихід з гри)

        private void yesButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        // Коли натиснута кнопка No (повернення в меню)
        private void noButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            playButton.Visible = true;
            exitButton.Visible = true;
            colorButton.Visible = false;
            trafic1.Top = -130;
            trafic2.Top = -400;
            Coin.Top = -500;
            Player.Left = 420;
            Player.Top = 520;
            labelLose.Visible = false;
            restartButton.Visible = false;
            GoMenuButton.Visible = false;
            labelCoins.Visible = false;
            settingsButton.Visible = true;
            countCoins = 0;
            labelCoins.Text = "Coins: " + countCoins.ToString();
            lose = false;
            yesButton.Visible = false;
            noButton.Visible = false;
            exitLabel.Visible = false;
            totalCoinsLabel.Visible = true;
            Racelogo.Visible = true;

        }
        // Коли натиснута кнопка Menu(Вихід з меню налаштувань)
        private void exitSettingsButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            playButton.Visible = true;
            exitButton.Visible = true;
            colorButton.Visible = false;
            trafic1.Top = -130;
            trafic2.Top = -400;
            Coin.Top = -500;
            Player.Left = 420;
            Player.Top = 520;
            labelLose.Visible = false;
            restartButton.Visible = false;
            GoMenuButton.Visible = false;
            labelCoins.Visible = false;
            settingsButton.Visible = true;
            countCoins = 0;
            labelCoins.Text = "Coins: " + countCoins.ToString();
            lose = false;
            yesButton.Visible = false;
            noButton.Visible = false;
            exitLabel.Visible = false;
            exitSettingsButton.Visible = false;
            audioButton.Visible = false;
            totalCoinsLabel.Visible = true;
            Racelogo.Visible = true;

        }

        // Коли натиснута кнопка Audio
        private void audioButton_Click(object sender, EventArgs e)
        {
            if (soundEnabled)
            {

                Music.StopMenuMusic();
                soundEnabled = false;
            }
            else
            {
               Music.PlayMenuMusic();
                soundEnabled = true;
            }



        }
    }
}
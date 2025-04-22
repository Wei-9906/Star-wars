namespace Tank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int firedirection = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Visible = false;
            switch (e.KeyCode)
            {

                case Keys.Up:
                    pictureBox1.Image = Image.FromFile("tank1.gif");
                    pictureBox1.Top = pictureBox1.Top - 5;
                    pictureBox2.Top = pictureBox1.Top - 30;
                    pictureBox2.Left = pictureBox1.Left + 35;
                    firedirection = 1;
                    break;

                case Keys.Down:
                    pictureBox1.Image = Image.FromFile("tank3.gif");
                    pictureBox1.Top = pictureBox1.Top + 5;
                    pictureBox2.Top = pictureBox1.Top + 70;
                    pictureBox2.Left = pictureBox1.Left + 40;
                    firedirection = 2;
                    break;

                case Keys.Left:
                    pictureBox1.Image = Image.FromFile("tank4.gif");
                    pictureBox1.Left = pictureBox1.Left - 5;
                    pictureBox2.Top = pictureBox1.Top + 20;
                    pictureBox2.Left = pictureBox1.Left - 25;
                    firedirection = 3;
                    break;

                case Keys.Right:
                    pictureBox1.Image = Image.FromFile("tank2.gif");
                    pictureBox1.Left = pictureBox1.Left + 5;
                    pictureBox2.Top = pictureBox1.Top + 30;
                    pictureBox2.Left = pictureBox1.Left + 110;
                    firedirection = 4;
                    break;

                case Keys.Space:
                    pictureBox2.Visible = true;
                    timer1.Enabled= true;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Interval = 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (firedirection == 1)
                {
                    pictureBox2.Top -= 4;
                }
                else if (firedirection == 2)
                {
                    pictureBox2.Top += 4;
                }
                else if (firedirection == 3)
                {
                    pictureBox2.Left -= 4;
                }
                else if (firedirection == 4)
                {
                    pictureBox2.Left += 4;
                }
            
        }
    }
}
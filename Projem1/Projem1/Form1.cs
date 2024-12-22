namespace Projem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 10 , yerY = 10, can = 3 ;

        private void CarpmaOlayý ()
        {
            // label2 carpma 
            if (ball.Top <= label2.Bottom)
                yerY = yerY * -1;

            // kontrole carpma olayý
            if (ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
                yerY = yerY * -1;

            // saða carpma olayý

            else if (ball.Right >= label4.Left)
                yerX = yerX * -1;

            // sol kenara çarpma olayý

            else if (ball.Left <= label1.Right)
                yerX= yerX * -1;
        }

        private void YanmaOlayý (object sender, EventArgs e)
        {
            if (ball.Top >= label4.Bottom)
            {
                if (can > 0)
                {

                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandýn Çýk Kalan can >=" + can.ToString());
                   
                }

                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun bitti", "", MessageBoxButtons.OK);
                }

            }
            label3.Text = can.ToString();
        }
        private void TopBasa()
        {
            ball.Location= new Point (240, 152);
        }
        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void kontrol_MouseMove(object sender, MouseEventArgs e)
        {
            TopBasa();
            kontrol.Left = e.X;
            
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarpmaOlayý();
            YanmaOlayý(sender, e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }
    }
}

namespace Projem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 10 , yerY = 10, can = 3 ;

        private void CarpmaOlay� ()
        {
            // label2 carpma 
            if (ball.Top <= label2.Bottom)
                yerY = yerY * -1;

            // kontrole carpma olay�
            if (ball.Bottom >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)
                yerY = yerY * -1;

            // sa�a carpma olay�

            else if (ball.Right >= label4.Left)
                yerX = yerX * -1;

            // sol kenara �arpma olay�

            else if (ball.Left <= label1.Right)
                yerX= yerX * -1;
        }

        private void YanmaOlay� (object sender, EventArgs e)
        {
            if (ball.Top >= label4.Bottom)
            {
                if (can > 0)
                {

                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yand�n ��k Kalan can >=" + can.ToString());
                   
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
            CarpmaOlay�();
            YanmaOlay�(sender, e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }
    }
}

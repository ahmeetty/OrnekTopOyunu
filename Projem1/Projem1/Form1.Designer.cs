namespace Projem1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            kontrol = new Button();
            ball = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GrayText;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(23, 463);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Coral;
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(569, 21);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(830, 49);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 2;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.GrayText;
            label4.Location = new Point(559, 9);
            label4.Name = "label4";
            label4.Size = new Size(23, 463);
            label4.TabIndex = 0;
            // 
            // kontrol
            // 
            kontrol.AutoSize = true;
            kontrol.BackColor = Color.DarkOrchid;
            kontrol.Location = new Point(214, 451);
            kontrol.Name = "kontrol";
            kontrol.Size = new Size(121, 21);
            kontrol.TabIndex = 3;
            kontrol.UseVisualStyleBackColor = false;
            kontrol.MouseMove += kontrol_MouseMove;
            // 
            // ball
            // 
            ball.BackColor = Color.Red;
            ball.Location = new Point(240, 152);
            ball.Name = "ball";
            ball.Size = new Size(15, 16);
            ball.TabIndex = 4;
            ball.UseVisualStyleBackColor = false;
            ball.Click += ball_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(718, 49);
            button1.Name = "button1";
            button1.Size = new Size(15, 16);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ball_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 518);
            Controls.Add(button1);
            Controls.Add(ball);
            Controls.Add(kontrol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button kontrol;
        private Button ball;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

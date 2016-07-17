using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facemsoft4
{
    public partial class Form1 : Form
    {
        public Game game = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            New_Game();
        }
        private void New_Game()
        {
            game = new Game();
            NameForm mf = new NameForm();
            mf.ShowDialog();
            label2.Text = "";
            foreach (char c in Game.game_word.Text)
            {
                label2.Text += "_ ";
            }
            panel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Game.game_word.Text.ToUpper().Contains(textBox1.Text))
            {
                int i = 0;
                string new_label_text = "";
                foreach (char c in Game.game_word.Text)
                {
                    if (label2.Text[i] == '_')
                    {
                        if (c.ToString().ToUpper() == textBox1.Text)
                        {
                            new_label_text += textBox1.Text + " ";
                        }
                        else
                        {
                            new_label_text += "_ ";
                        }
                    }
                    else
                    {
                        new_label_text += label2.Text[i] + " ";
                    }
                    i = i + 2;
                }
                label2.Text = new_label_text;
            }
            else
            {
                Game.nb_of_lifes--;
                panel1.Invalidate();
                //desenez uramtorul spanzurat
            }
            this.textBox1.Text = "";
            if (Game.nb_of_lifes == 0)
            {
                MessageBox.Show("Game Over!");
                New_Game();
            }
            else if (!label2.Text.Contains('_'))
            {
                DialogResult dr = MessageBox.Show("You won!\r\nYour score is " + Game.nb_of_lifes + ".\r\nDo you Wanna start a new game?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                using (FileStream fs = new FileStream("E:\\Projects\\C#\\facemsoft4\\Hangman.dat", FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(Game.game_player.Name + "|" + Game.nb_of_lifes + "|" + Game.date_started);
                    }
                }
                if (dr == DialogResult.Yes)
                {
                    New_Game();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Game();
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreForm sf = new ScoreForm();
            sf.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hangman created cu ajutor de pe FacemSoft", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch (Game.nb_of_lifes)
            {
                case 5: ; break;
                case 4:
                    Rectangle rec = new Rectangle(panel1.Width / 2 - 20, 10, 40, 40);
                    g.DrawEllipse(new Pen(Color.Black), rec);
                    break;
                case 3:
                    Rectangle rec2 = new Rectangle(panel1.Width / 2 - 20, 10, 40, 40);
                    g.DrawEllipse(new Pen(Color.Black), rec2);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 50, panel1.Width / 2, 120);
                    break;
                case 2:
                    Rectangle rec3 = new Rectangle(panel1.Width / 2 - 20, 10, 40, 40);
                    g.DrawEllipse(new Pen(Color.Black), rec3);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 50, panel1.Width / 2, 120);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 70, panel1.Width / 2 - 30, 90);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 70, panel1.Width / 2 + 30, 90);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 120, panel1.Width / 2 - 30, 140);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 120, panel1.Width / 2 + 30, 140);
                    break;
                case 1:
                    Rectangle rec4 = new Rectangle(panel1.Width / 2 - 20, 10, 40, 40);
                    g.DrawEllipse(new Pen(Color.Black), rec4);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 50, panel1.Width / 2, 120);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 70, panel1.Width / 2 - 30, 90);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 70, panel1.Width / 2 + 30, 90);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 120, panel1.Width / 2 - 30, 140);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 120, panel1.Width / 2 + 30, 140);
                    g.DrawLine(new Pen(Color.Black), 120, 5, 120, 180);
                    g.DrawLine(new Pen(Color.Black), 120, 5, panel1.Width / 2, 5);
                    break;
                case 0:
                    Rectangle rec5 = new Rectangle(panel1.Width / 2 - 20, 10, 40, 40);
                    g.DrawEllipse(new Pen(Color.Black), rec5);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 50, panel1.Width / 2, 120);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 70, panel1.Width / 2 - 30, 90);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 70, panel1.Width / 2 + 30, 90);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 120, panel1.Width / 2 - 30, 140);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 120, panel1.Width / 2 + 30, 140);
                    g.DrawLine(new Pen(Color.Black), 120, 5, 120, 180);
                    g.DrawLine(new Pen(Color.Black), 120, 5, panel1.Width / 2, 5);
                    g.DrawLine(new Pen(Color.Black), panel1.Width / 2, 5, panel1.Width / 2, 10);
                    g.DrawString("GAME OVER", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold), Brushes.Red, panel1.Width / 2 - 60, 60);
                    break;
            }
        }
    }
}

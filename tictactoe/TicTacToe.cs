using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        private void MuteAllButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void DecideTheWinner()
        {
            // first checking O winning or not
            // 123
            if (button1.Text.ToString().Equals("O") && button2.Text.ToString().Equals("O") && button3.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            // 456
            else if (button4.Text.ToString().Equals("O") && button5.Text.ToString().Equals("O") && button6.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            // 789
            else if (button7.Text.ToString().Equals("O") && button8.Text.ToString().Equals("O") && button9.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            // 147
            else if (button1.Text.ToString().Equals("O") && button4.Text.ToString().Equals("O") && button7.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            // 258
            else if (button2.Text.ToString().Equals("O") && button5.Text.ToString().Equals("O") && button8.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            // 369
            else if (button3.Text.ToString().Equals("O") && button6.Text.ToString().Equals("O") && button9.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            // 159
            else if (button1.Text.ToString().Equals("O") && button5.Text.ToString().Equals("O") && button9.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            // 357
            else if (button3.Text.ToString().Equals("O") && button5.Text.ToString().Equals("O") && button7.Text.ToString().Equals("O"))
            {
                lbl_clickcount.Text = "O won the match";
                MuteAllButtons();
            }
            else
            {
                // continue playing
            }

            // checking X winning or not

            // 123
            if (button1.Text.ToString().Equals("X") && button2.Text.ToString().Equals("X") && button3.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            // 456
            else if (button4.Text.ToString().Equals("X") && button5.Text.ToString().Equals("X") && button6.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            // 789
            else if (button7.Text.ToString().Equals("X") && button8.Text.ToString().Equals("X") && button9.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            // 147
            else if (button1.Text.ToString().Equals("X") && button4.Text.ToString().Equals("X") && button7.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            // 258
            else if (button2.Text.ToString().Equals("X") && button5.Text.ToString().Equals("X") && button8.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            // 369
            else if (button3.Text.ToString().Equals("X") && button6.Text.ToString().Equals("X") && button9.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            // 159
            else if (button1.Text.ToString().Equals("X") && button5.Text.ToString().Equals("X") && button9.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            // 357
            else if (button3.Text.ToString().Equals("X") && button5.Text.ToString().Equals("X") && button7.Text.ToString().Equals("X"))
            {
                lbl_clickcount.Text = "X won the match";
                MuteAllButtons();
            }
            else
            {
                // continue playing
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_clickcount.Text = 0.ToString();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button1.Text = "X";
                button1.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if(count%2==0)
                {
                    button1.Text = "O";
                    button1.Enabled = false;
                }
                else
                {
                    button1.Text = "X";
                    button1.Enabled = false;
                }
                
            }

            DecideTheWinner();

            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button2.Text = "X";
                button2.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button2.Text = "O";
                    button2.Enabled = false;
                }
                else
                {
                    button2.Text = "X";
                    button2.Enabled = false;
                }

            }
            DecideTheWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button3.Text = "X";
                button3.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button3.Text = "O";
                    button3.Enabled = false;
                }
                else
                {
                    button3.Text = "X";
                    button3.Enabled = false;
                }

            }
            DecideTheWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button4.Text = "X";
                button4.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button4.Text = "O";
                    button4.Enabled = false;
                }
                else
                {
                    button4.Text = "X";
                    button4.Enabled = false;
                }

            }
            DecideTheWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button5.Text = "X";
                button5.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button5.Text = "O";
                    button5.Enabled = false;
                }
                else
                {
                    button5.Text = "X";
                    button5.Enabled = false;
                }

            }
            DecideTheWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button6.Text = "X";
                button6.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button6.Text = "O";
                    button6.Enabled = false;
                }
                else
                {
                    button6.Text = "X";
                    button6.Enabled = false;
                }

            }
            DecideTheWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button7.Text = "X";
                button7.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button7.Text = "O";
                    button7.Enabled = false;
                }
                else
                {
                    button7.Text = "X";
                    button7.Enabled = false;
                }

            }
            DecideTheWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button8.Enabled = false;
                button8.Text = "X";
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button8.Text = "O";
                    button8.Enabled = false;
                }
                else
                {
                    button8.Text = "X";
                    button8.Enabled = false;
                }

            }
            DecideTheWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string clickcount = lbl_clickcount.Text.ToString();
            if (clickcount.Equals("0"))
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                button9.Text = "X";
                button9.Enabled = false;
            }
            else
            {
                int count = Int32.Parse(lbl_clickcount.Text.ToString());
                count = count + 1;
                lbl_clickcount.Text = count.ToString();
                if (count % 2 == 0)
                {
                    button9.Text = "O";
                    button9.Enabled = false;
                }
                else
                {
                    button9.Text = "X";
                    button9.Enabled = false;
                }

            }
            DecideTheWinner();
        }
    }
}

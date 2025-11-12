using _10__Tic_Tac_Game_my_solution.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _10__Tic_Tac_Game_my_solution
{
    public partial class Form1 : Form
    {
        SoundPlayer clickSound = new SoundPlayer(Properties.Resources.click);
        SoundPlayer clickSound2 = new SoundPlayer(Properties.Resources.win);
        SoundPlayer clickSound3 = new SoundPlayer(Properties.Resources.Reset);
        short Counter = 0;

        bool isPlayer1()
        {
            Counter++;
            return (Counter % 2 != 0);
        
        }

        void UpdateButtonsTags(object sender)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Tag != null)
            {
                MessageBox.Show("can't choose this","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

           

            clickSound.Play();

            if (isPlayer1())
            {
                clickedButton.Tag = "1";
                clickedButton.Image = Resources.O;
                lblPlayerTurn.Text = "Player2";
            }
            else
            {
                clickedButton.Tag = "2";
                clickedButton.Image = Resources.X;
                lblPlayerTurn.Text = "Player1";
            }

           
            
        }

        bool isPlayer1_Win()
        {
            return (button1.Tag == "1" && button2.Tag == "1" && button3.Tag == "1") ||
                   (button4.Tag == "1" && button5.Tag == "1" && button6.Tag == "1") ||
                   (button7.Tag == "1" && button8.Tag == "1" && button9.Tag == "1") ||

                   (button1.Tag == "1" && button4.Tag == "1" && button7.Tag == "1") ||
                   (button2.Tag == "1" && button5.Tag == "1" && button8.Tag == "1") ||
                   (button3.Tag == "1" && button6.Tag == "1" && button9.Tag == "1") ||

                   (button1.Tag == "1" && button5.Tag == "1" && button9.Tag == "1") ||
                   (button3.Tag == "1" && button5.Tag == "1" && button7.Tag == "1");
        }

        bool isPlayer2_Win()
        {
            return (button1.Tag == "2" && button2.Tag == "2" && button3.Tag == "2") ||
                   (button4.Tag == "2" && button5.Tag == "2" && button6.Tag == "2") ||
                   (button7.Tag == "2" && button8.Tag == "2" && button9.Tag == "2") ||

                   (button1.Tag == "2" && button4.Tag == "2" && button7.Tag == "2") ||
                   (button2.Tag == "2" && button5.Tag == "2" && button8.Tag == "2") ||
                   (button3.Tag == "2" && button6.Tag == "2" && button9.Tag == "2") ||

                   (button1.Tag == "2" && button5.Tag == "2" && button9.Tag == "2") ||
                   (button3.Tag == "2" && button5.Tag == "2" && button7.Tag == "2");
        }

        void DisableGame()
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

        void ResetGame()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Tag = null;
            button2.Tag = null;
            button3.Tag = null;
            button4.Tag = null;
            button5.Tag = null;
            button6.Tag = null;
            button7.Tag = null;
            button8.Tag = null;
            button9.Tag = null;

            button1.Image = Resources.question_mark_96;
            button2.Image = Resources.question_mark_96;
            button3.Image = Resources.question_mark_96;
            button4.Image = Resources.question_mark_96;
            button5.Image = Resources.question_mark_96;
            button6.Image = Resources.question_mark_96;
            button7.Image = Resources.question_mark_96;
            button8.Image = Resources.question_mark_96;
            button9.Image = Resources.question_mark_96;

            lblPlayerTurn.Text = "Player1";
            lblWinResult.Text = "In Progress";


            Counter = 0;
        }

        void WinResult()
        {
            if(isPlayer1_Win())
            {
                lblWinResult.Text = "Player 1";
                DisableGame();
                clickSound2.Play();
                return;
            }

            if (isPlayer2_Win())
            {
                lblWinResult.Text = "Player 2";
                DisableGame();
                clickSound2.Play();
                return;
            }

            if(Counter == 9)
            {
                lblWinResult.Text = "Draw";
                DisableGame();
                clickSound2.Play();
                return;
            }

        }

        void UpdateGame(object sender)
        {
            UpdateButtonsTags(sender);
            WinResult();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UpdateGame(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetGame();
            clickSound3.Play();
        }
    }
}

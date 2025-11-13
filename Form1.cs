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
        

        enum enPlayers { Player1, Player2 };
        enPlayers enPlayerTurn = enPlayers.Player1;

        enum enWinner {  Player1, Player2 , Draw , InProgress };
        stGameStatus GameStatus;
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        public bool ChickValues(Button btn1, Button btn2 , Button btn3)
        {
            if(btn1.Tag.ToString() !="?" && btn1.Tag.ToString()== btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                clickSound2.Play();

                if (btn1.Tag.ToString()=="X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;

                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;

        }

        public void ChickWinner()
        {
            if (ChickValues(button1, button2, button3))
                return;

            if (ChickValues(button4, button5, button6))
                return;

            if (ChickValues(button7, button8, button9))
                return;

            if (ChickValues(button1, button4, button7))
                return;


            if (ChickValues(button2, button5, button8))
                return;

            if (ChickValues(button3, button6, button9))
                return;

            if (ChickValues(button1, button5, button9))
                return;

            if (ChickValues(button3, button5, button7))
                return;

        }

        public void ChangeImage(Button btn)
        {

            if (btn.Tag.ToString() == "?")
            {
                clickSound.Play();

                switch (enPlayerTurn)
                {
                    case enPlayers.Player1:
                        btn.Image = Resources.X;
                        enPlayerTurn = enPlayers.Player2;
                        lblPlayerTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        ChickWinner();
                        break;
                    case enPlayers.Player2:
                        btn.Image = Resources.O;
                        enPlayerTurn = enPlayers.Player1;
                        lblPlayerTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        ChickWinner();
                        break;
                }
            }

            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        public void EndGame()
        {

            lblPlayerTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lblWinResult.Text = "Player1";
                    break;

                case enWinner.Player2:

                    lblWinResult.Text = "Player2";
                    break;

                default:

                    lblWinResult.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RestButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

        }

        private void RestartGame()
        {

            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            enPlayerTurn = enPlayers.Player1;
            lblPlayerTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.InProgress;
            lblWinResult.Text = "In Progress";



        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

       
        private void button10_Click(object sender, EventArgs e)
        {
            clickSound3.Play();
            RestartGame();

        }
    }
}

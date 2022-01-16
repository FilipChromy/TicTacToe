using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TicTacToe
{
    public static class GameControl
    {
        private static string _playerTurn = "X";
        public static void PlaceMove(TextBlock textBlock)
        {
            textBlock.Text = _playerTurn;
            ChangePlayer();
        }
        public static void ChangePlayer(string player)
        {
            // force select player
            _playerTurn = player;
        }
        public static void ChangePlayer()
        {
            if (_playerTurn == "X")
            {
                _playerTurn = "O";
            }
            else
            {
                _playerTurn = "X";
            }
        }
        public static void GameStateUpdate(TextBlock gameState)
        {
            if (gameState.Text.StartsWith("X"))
            {
                gameState.Text = "O plays";
            }
            else
            {
                gameState.Text = "X plays";
            }
        }
        public static void ValidateWinnerX(
            TextBlock button1, TextBlock button2, TextBlock button3, 
            TextBlock button4, TextBlock button5, TextBlock button6,
            TextBlock button7, TextBlock button8, TextBlock button9,
            TextBlock gameState, List<Button> buttons
            )
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                gameState.Text = "Player X Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
        }

        public static void ValidateWinnerO(
            TextBlock button1, TextBlock button2, TextBlock button3,
            TextBlock button4, TextBlock button5, TextBlock button6,
            TextBlock button7, TextBlock button8, TextBlock button9,
            TextBlock gameState, List<Button> buttons
            )
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                gameState.Text = "Player O Wins!";
                foreach (Button bt in buttons)
                {
                    bt.IsEnabled = false;
                }
            }
        }
        public static void CheckForTie(List<TextBlock> buttonValues, TextBlock gameState, List<Button> bts)
        {
            bool allPositionsOccupied = true;
            foreach (TextBlock tb in buttonValues)
            {
                if (tb.Text.Equals(""))
                {
                    allPositionsOccupied = false;
                }
            }
            if (allPositionsOccupied && !gameState.Text.EndsWith("Wins!"))
            {
                foreach (Button bt in bts)
                {
                    bt.IsEnabled = false;
                }
                gameState.Text = "The game was a tie!";
            }
        }
    }
}

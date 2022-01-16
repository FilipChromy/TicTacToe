using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (buttonOneText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonOneText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (buttonTwoText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonTwoText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (buttonThreeText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonThreeText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (buttonFourText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonFourText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (buttonFiveText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonFiveText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (buttonSixText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonSixText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (buttonSevenText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonSevenText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (buttonEightText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonEightText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (buttonNineText.Text.Equals(""))
            {
                GameControl.PlaceMove(buttonNineText);
                GameControl.GameStateUpdate(gameState);
                GameControl.ValidateWinnerX(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.ValidateWinnerO(
                    buttonOneText, buttonTwoText, buttonThreeText,
                    buttonFourText, buttonFiveText, buttonSixText,
                    buttonSevenText, buttonEightText, buttonNineText, gameState, new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 });
                GameControl.CheckForTie(AllButtonValues(), gameState, AllButtons());
            }
        }

        private List<Button> AllButtons()
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(bt1);
            buttons.Add(bt2);
            buttons.Add(bt3);
            buttons.Add(bt4);
            buttons.Add(bt5);
            buttons.Add(bt6);
            buttons.Add(bt7);
            buttons.Add(bt8);
            buttons.Add(bt9);
            return buttons;
        }
        private List<TextBlock> AllButtonValues()
        {
            List<TextBlock> values = new List<TextBlock>();
            values.Add(buttonOneText);
            values.Add(buttonTwoText);
            values.Add(buttonThreeText);
            values.Add(buttonFourText);
            values.Add(buttonFiveText);
            values.Add(buttonSixText);
            values.Add(buttonSevenText);
            values.Add(buttonEightText);
            values.Add(buttonNineText);
            return values;
        }
        private void restartGameButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBlock tb in AllButtonValues())
            {
                tb.Text = "";
            }
            foreach (Button bt in AllButtons())
            {
                bt.IsEnabled = true;
            }
            gameState.Text = "X Plays";
            GameControl.ChangePlayer("X");
        }
    }
}

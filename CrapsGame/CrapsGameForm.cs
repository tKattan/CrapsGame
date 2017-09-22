using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class CrapsGameMain : Form
    {
        //enumeration with constants that represent the game status
        public enum Status { CONTINUE, WON, LOST }

        //enumeration with constants that represent whether the RollDice Button will start a game or
        //roll the dice during a game.
        private enum RollDiceButtonStatus
        {
            Wager, FirstRoll, NextRoll, Reset
        }//end enum

        CrapsGame Game = new CrapsGame();//CrapsGame object
        private static int bankBalance = 1000;//initial bankBalance
        private static int wager = 0;//wager to use to modify bankBalance
        private static RollDiceButtonStatus GameStatus = CrapsGameMain.RollDiceButtonStatus.Wager;//the status of the game used to tell
                                                                                                  //the RollDiceButton what to do
        private static Status PlayStatus;//the status of the game to know when win or lose
        //constructor
        public CrapsGameMain()
        {
            InitializeComponent();
            bankbalanceTextbox.Text = bankBalance.ToString();
        }//end constructor

        //method rolldiceButton_Click
        private void rolldiceButton_Click(object sender, EventArgs e)
        {
            if (GameStatus == RollDiceButtonStatus.Wager)//for the start of a new game
            {
                try//only place where the user can input anything so this is the only place where they can break stuff... I hope
                {
                    if (String.IsNullOrWhiteSpace(wagerTextbox.Text))//verify that the textbox is not null, empty or white space
                    {
                        wagerTextbox.Clear();
                        messageTextbox.Clear();
                        messageTextbox.Text = "The wager can not be nothing. Please enter a proper value.";
                    }//end if
                    if (int.Parse(wagerTextbox.Text) <= 0)//verify that the user hasnt input a negative value or a zero
                    {
                        wagerTextbox.Clear();
                        messageTextbox.Clear();
                        messageTextbox.Text = "The wager can not be zero or negative. Please enter a proper value.";
                    }//end if
                    else if (int.Parse(wagerTextbox.Text) > bankBalance)//verify that the user hasnt input a value higher than bankBalance
                    {
                        wagerTextbox.Clear();
                        messageTextbox.Clear();
                        messageTextbox.Text = "The wager can not be more than your bank balace. Please enter a lower value.";
                    }//end else if
                    else//if the value is valid... I hope
                    {
                        messageTextbox.Clear();

                        wager = int.Parse(wagerTextbox.Text);//parse the text into the wager variable to make it easier to modify
                        bankBalance -= wager;//remove the wager from bankBalance
                        bankbalanceTextbox.Text = bankBalance.ToString();//display the new bankBalance

                        messageTextbox.Text = $"You have bet {wager}.\r\nTo roll dice and find your point press Roll Dice.";
                        gameTextbox.Text = $"Wager: {wager}\r\n";
                        
                        GameStatus = RollDiceButtonStatus.FirstRoll;//change the game status
                    }//end else
                }
                catch (FormatException formatException)//catch the format exception
                {
                    wagerTextbox.Clear();
                    messageTextbox.Clear();
                    messageTextbox.Text = $"{formatException.Message}\r\nYou have to enter an integer!";
                }
            }//end if
            else if (GameStatus == RollDiceButtonStatus.FirstRoll)
            {
                messageTextbox.Clear();

                var dice = Game.RollDice();
                gameTextbox.AppendText( $"You rolled a {dice[0]} and a {dice[1]} making a total of {dice[2]}.\r\n" );

                PlayStatus = (Status)Game.FirstRoll(dice[2]);

                switch (PlayStatus)
                {
                    case Status.CONTINUE:
                        gameTextbox.AppendText($"Your point is: {Game.MyPoint}\r\n");
                        messageTextbox.Text = $"Your point is {Game.MyPoint}. Roll again and make your point to win or roll a seven to lose.";
                        GameStatus = RollDiceButtonStatus.NextRoll;//change the game status
                        break;
                    case Status.WON:
                        gameTextbox.AppendText("Congratulations you have won!");
                        messageTextbox.Text = "You have won the game. To continue press the Roll Dice button.";

                        bankBalance += (wager * 2);
                        bankbalanceTextbox.Text = bankBalance.ToString();

                        GameStatus = RollDiceButtonStatus.Reset;//change the game status
                        break;
                    case Status.LOST:
                        gameTextbox.AppendText("You have lost the game.");
                        messageTextbox.Text = "You have lost. To continue press the Roll Dice button.";

                        GameStatus = RollDiceButtonStatus.Reset;//change the game status
                        break;
                }//end switch
            }//end if
            else if (GameStatus == RollDiceButtonStatus.NextRoll)
            {
                messageTextbox.Clear();

                var dice = Game.RollDice();
                gameTextbox.AppendText($"You rolled a {dice[0]} and a {dice[1]} making a total of {dice[2]}.\r\n");

                PlayStatus = (Status)Game.NextRoll(dice[2]);

                switch (PlayStatus)
                {
                    case Status.CONTINUE:
                        messageTextbox.Text = $"You did not make your point.\r\nYour point is {Game.MyPoint}.\r\n" +
                            "Roll again and make your point to win or roll a seven to lose.";
                        break;
                    case Status.WON:
                        gameTextbox.AppendText("Congratulations you have won!");
                        messageTextbox.Text = "You have won the game by making your point. To continue press the Roll Dice button.";

                        bankBalance += (wager * 2);
                        bankbalanceTextbox.Text = bankBalance.ToString();

                        GameStatus = RollDiceButtonStatus.Reset;//change the game status
                        break;
                    case Status.LOST:
                        gameTextbox.AppendText("You have lost the game.");
                        messageTextbox.Text = "You have lost by rolling a seven. To continue press the Roll Dice button.";

                        GameStatus = RollDiceButtonStatus.Reset;//change the game status
                        break;
                }//end switch
            }//end if
            else if (GameStatus == RollDiceButtonStatus.Reset)
            {
                gameTextbox.Clear();
                messageTextbox.Clear();
                messageTextbox.Text = "To play a game enter a wager and press the Roll Dice button.";
                Game.ReInitialize();
                GameStatus = RollDiceButtonStatus.Wager;

                //check if bankbalance is zero
                if (int.Parse(bankbalanceTextbox.Text) == 0)
                {
                    MessageBox.Show("Your Bank Balance has reached zero! You have no money to play. Goodbye",
                        "Lack of Funds!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Application.Exit();
                }
            }
        }//end method rolldiceButton_Click

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end method exitButton_Click

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You roll two dice. Each die has six faces, which contain one, two, three, four, five " +
                "and six spots, respectively.After the dice have come to rest, the sum of the spots on the two upward faces is " +
                "calculated.If the sum is 7 or 11 on the first throw, you win. If the sum is 2, 3 or 12 on the first throw " +
                "(called “craps”), you lose (i.e., “the house” wins). If the sum is 4, 5, 6, 8, 9 or 10 on the first throw, that " +
                "sum becomes your “point.” To win, you must continue rolling the dice until you “make your point” (i.e., roll that same " +
                "point value). You lose by rolling a 7 before making your point.", "Instructions");
        }//end method instructionsButton_Click
    }
}

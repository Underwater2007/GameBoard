/*Rushi Patel
 2024-1-14
GameBoard*/
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

namespace GameBoard
{
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private Button[] btnTiles = new Button[17];//array for blocks
        private int[] values = new int[17];//16 different values
        int playerPosition = 0;//tell where the player is 
        int roll;//for the dice roll

        StreamWriter outputFile;
        Random rand = new Random();//new random 

        //properties for buttons
        int btnLeft = 137, btnTop = 5;
        const int BTNWIDTH = 60, BTNHEIGHT = 60;
        const int BTNLEFTSIDE = 65;
        const int BTNTOPSIDE = 65;
       
        private void LoadBlocks()
        {
            for (int i = 0; i < 17; i++)
            {
                //create buttons
                Button blocks = new Button();
                blocks.Left = btnLeft;
                blocks.Top = btnTop;
                blocks.Width = BTNWIDTH;
                blocks.Height = BTNHEIGHT;
                blocks.BackColor = Color.White; 

                //rearrange the button 
                if (i < 4) btnLeft += BTNLEFTSIDE;
                else if (i >= 4 && i < 8) btnTop += BTNTOPSIDE;
                else if (i >= 8 && i < 12) btnLeft -= BTNLEFTSIDE;
                else if (i >= 12 && i < 17) btnTop -= BTNTOPSIDE;
                
                if(i==0)
                {
                    blocks.Text = "Start";
                }
                if(i==4||i==8||i==12)
                {
                    blocks.BackColor = Color.Yellow;//the colors are changed for buttons 4,8 and 12
                }
                if(i==2||i==10)
                {
                    blocks.BackColor = Color.Red;//colors are changed fot buttons 2 and 10
                }
                this.Controls.Add(blocks);
                btnTiles[i] = blocks;//adds the buttons

            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnRoll1.Visible = true;
            btnRoll100Dice.Visible = true;
            lblInfo.Visible = false;
            LoadBlocks();//call the method
        }

        private void btnRoll1_Click(object sender, EventArgs e)
        {
            RollDie();//rolls the die
            lblPrompt.Text = "you rolled a " + roll + "\nyour player is on block " + playerPosition;//prompts the user
        }

        private void RollDie()
        {
            roll = rand.Next(1, 7);//value for the dice
            btnTiles[playerPosition].BackColor = Color.White;
            playerPosition = (playerPosition + roll) % 16;//the players position is wraped back to one when it comes to the end 
            if (playerPosition == 4 || playerPosition == 8 || playerPosition == 12)//if the player is at blocks 4,8 and 12 it moves back 2 spaces 
            {
                // Move player back 2 spots
                values[playerPosition]++;
                btnTiles[playerPosition].Text = values[playerPosition].ToString();
                playerPosition = (playerPosition - 2) % 16;
               
            }
            if (playerPosition == 2 || playerPosition == 10)//if player is at blocks 2 and 10 it moves back to the start
            {
                values[playerPosition]++;
                btnTiles[playerPosition].Text = values[playerPosition].ToString();
                playerPosition = 0;
            }
            values[playerPosition]++;
            btnTiles[playerPosition].Text = values[playerPosition].ToString();//updates the score
            btnTiles[playerPosition].BackColor = Color.Aqua;
        }

        private void btnRoll100Dice_Click(object sender, EventArgs e)
        {
            rollDice100();//rolls 100 times 
            lblPrompt.Text = "your player is on block " + playerPosition;
        }

        private void rollDice100()
        {
           
            //the code is the same as the one in rolldie but this time it shows results for 100 die roll
            for (int i = 0; i <= 100; i++)
            {
                roll = rand.Next(1, 7);
                btnTiles[playerPosition].BackColor = Color.White;
                playerPosition = (playerPosition + roll) % 16;
                if (playerPosition == 4 || playerPosition == 8 || playerPosition == 12)
                {
                    values[playerPosition]++;
                    btnTiles[playerPosition].Text = values[playerPosition].ToString();
                    playerPosition = (playerPosition - 2) % 16;
                }
                if (playerPosition == 2 || playerPosition == 10)
                {
                    values[playerPosition]++;
                    btnTiles[playerPosition].Text = values[playerPosition].ToString();
                    playerPosition = 0;
                }
                values[playerPosition]++;
                btnTiles[playerPosition].Text = values[playerPosition].ToString();
                btnTiles[playerPosition].BackColor = Color.Aqua;
               
            }
            outputFile = File.CreateText("OutputFile.txt");//creats a new file
            for (int i = 0; i < 16; i++)
            {
                outputFile.WriteLine("player landed on block "+ i + "  " + values[i]+" times".ToString());//prints the output in the file 
               //stores the output in the OutputFile.txt
            }
            outputFile.Close();//closes the file
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondHandGames
{
    public partial class Form1 : Form
    {// a game store contains the list of games and a current index
        GameStore gameStore;
        PictureBox pb1 = new PictureBox();
       
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            gameStore = new GameStore();



            Xbox game = new Xbox("Microsoft Studios", "Forza Horizon 4", "Xbox", new DateTime(2018, 10, 02), 50, Games.Condition.excellent);
            Xbox game1 = new Xbox("Rockstar", "Red Dead Redemption 2", "Xbox", new DateTime(2018, 10, 26), 55, Games.Condition.good);
            Xbox xcodbo3 = new Xbox("Treyarch", "Call of Duty: Black Ops 3", "Xbox", new DateTime(2015, 11, 06), 55, Games.Condition.good);
            Xbox GTAV = new Xbox("Rockstar", "Grand Theft Auto V", "Xbox", new DateTime(2013, 09, 17), 50, Games.Condition.excellent);
            Xbox xfallout4 = new Xbox("Bethesda Game Studios", "Fallout 4", "Xbox", new DateTime(2015, 11, 10), 55, Games.Condition.good);
            PlayStation spiderman = new PlayStation("Insomniac Games", "Spiderman", "PlayStation", new DateTime(2018, 09, 07), 55, Games.Condition.good);
            PlayStation psgame1 = new PlayStation("Rockstar", "Red Dead Redemption 2", "PlayStation", new DateTime(2018, 10, 26), 55, Games.Condition.excellent);
            PlayStation fallout4 = new PlayStation("Bethesda Game Studios", "Fallout 4", "PlayStation", new DateTime(2015, 11, 10), 55, Games.Condition.poor);
            PlayStation codbo3 = new PlayStation("Treyarch", "Call of Duty: Black Ops 3", "PlayStation", new DateTime(2015, 11, 06), 55, Games.Condition.fair);
            PlayStation PGTAV = new PlayStation("Rockstar", "Grand Theft Auto V", "PlayStation", new DateTime(2013, 09, 17), 50, Games.Condition.poor);
            gameStore.AddGame(game);
            gameStore.AddGame(game1);
            gameStore.AddGame(psgame1);
            gameStore.AddGame(spiderman);
            gameStore.AddGame(fallout4);
            gameStore.AddGame(codbo3);
            gameStore.AddGame(xcodbo3);
            gameStore.AddGame(GTAV);
            gameStore.AddGame(PGTAV);
            gameStore.AddGame(xfallout4);
            

            DisplayGame();
            
        }
        private void DisplayGame()
        {
            labelCurrentGame.Text = string.Format("Viewing {0} of {1}", gameStore.gamesCurrentlyDisplayed + 1, gameStore.NumberOfGames);

            TextBoxGames.Text = gameStore.DescribeCurrentGame();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            gameStore.StepToPreviousGame();
            DisplayGame();

           
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            gameStore.StepToNextGame();
            DisplayGame();

           
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            
        }

        

        private void PictureBoxCurrentGame(object sender, EventArgs e)
        {
            
        }

        private void buttonDeleteGame_Click(object sender, EventArgs e)
        {
            gameStore.DeleteGame(); //button to remove game from store
            DisplayGame();          //removes from store in real time
        }
    }
}

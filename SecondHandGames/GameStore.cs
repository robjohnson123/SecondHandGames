using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandGames

{
    public class GameStore
    {
        //This class has a list of games which will be for sale
        //It will determine a price of the game depending on the condition and age

        private List<Games> GameStock;

        private int GamesCurrentlyDisplayed = 0;


        public GameStore()
        {
            GameStock = new List<Games>();
        }


        public int gamesCurrentlyDisplayed
        {
            get { return GamesCurrentlyDisplayed; }
        }

        public int NumberOfGames
        {
            get { return GameStock.Count; }
        }


        public string DescribeCurrentGame()
        {
            string description;

            // if we have any games we ask the displayed game for its description
            if (GameStock.Count > 0)
            {
                description = GameStock[GamesCurrentlyDisplayed].Description();
            }
            else
            {
                description = "No games in stock";
            }
            return description;
        }

       
        public void AddGame(Games game)
        {
            GameStock.Add(game);
        }

        public void RemoveGameAt(int index)
        {
            if (index < GameStock.Count)
            {
                GameStock.RemoveAt(index);
                // make sure GameCurrentlyDisplayed is either zero or pointing at an existing game
                LegaliseGameCurentlyDisplayed();
            }
        }


        
        private void LegaliseGameCurentlyDisplayed()
        {
            if (GamesCurrentlyDisplayed > (GameStock.Count - 1))
            {
                GamesCurrentlyDisplayed = GameStock.Count - 1;     // not this will be -1 if stock is zero

                if (GamesCurrentlyDisplayed < 0)
                {
                    GamesCurrentlyDisplayed = 0;  // make sure its legal or zero....
                }
            }
        }



        public bool IsPreviousGame()
        {
            if (GamesCurrentlyDisplayed > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }

        public bool IsNextGame()
        {
            if (GamesCurrentlyDisplayed < GameStock.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StepToPreviousGame()
        {
            if (IsPreviousGame())
            {
                GamesCurrentlyDisplayed--;
            }
        }

        public void StepToNextGame()
        {
            if (IsNextGame())
            {
                GamesCurrentlyDisplayed++;
            }
        }
        public void DeleteGame()
        {
            if (GameStock.Count > 0)
            {
                GameStock.RemoveAt(GamesCurrentlyDisplayed);
                LegaliseGameCurentlyDisplayed();
            }
        }
    }
}



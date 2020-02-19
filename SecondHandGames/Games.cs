using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandGames
{
    // Games is an abstract base class, we inherit Xbox and PlayStation from this.
    public abstract class Games : IComparable
    {
        // Game's condition
        public enum Condition
        {
            poor,
            fair,
            good,
            excellent
        };

        protected string Manufacturer;
        protected string Game;
        protected string Console;
        protected DateTime dateManufactured;
        protected decimal originalPrice;
        protected Condition condition;
        protected string image;


        // constructor
        public Games(string Manufacturer, string Game, string Console, DateTime dateManufactured, decimal originalPrice, Condition condition)
        {
            this.Manufacturer = Manufacturer;
            this.Game = Game;
            this.Console = Console;
            this.dateManufactured = dateManufactured;
            this.originalPrice = originalPrice;
            this.condition = condition;
        }


        public int CalculateApproximateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(dateManufactured);
            int ageInYears = ageAsTimeSpan.Days / 365;  // doesn't take into account leap years - just approximate
            return ageInYears;
        }


        // this method has to be implemented in the derived class
        public abstract decimal CalculateApproximateValue();


        public virtual string Description()
        {
            // get a string describing the current game's condition from the names in the Condition enumeration
            string conditionName = Enum.GetName(typeof(Condition), condition); // we can get the enumeration name here eg. good or fair as text as opposed to its value

            // Describing the current game
            string description = string.Format("Manufacturer: {0}{1}Game: {2}{3}Console: {4}{5}Condition: {6}{7}Current Value: {8:c}",
                Manufacturer,
                Environment.NewLine,
                Game,
                Environment.NewLine,
                Console,
                Environment.NewLine,
                conditionName,
                Environment.NewLine,
                CalculateApproximateValue());

            return description;
        }

        
        int IComparable.CompareTo(object obj)
        {
            // iComparable returns   +1, 0 or -1
            Games otherGame = (Games)obj;
            decimal differenceInPrice = this.CalculateApproximateValue() - otherGame.CalculateApproximateValue();
            // we want to return +1, 0 or -1
            return Math.Sign(differenceInPrice);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHandGames
{
    public class PlayStation : Games
    {

        public PlayStation(string Manufacturer, string Game, string Console, DateTime dateManufactured, decimal originalPrice, Condition condition)
            : base(Manufacturer, Game, Console, dateManufactured, originalPrice, condition)
        {

        }



        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;

            if (condition == Condition.excellent)
            {
                value = originalPrice * 0.8m;        // 80% of original value
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.7m;        // 70% of original value
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.5m;        // 50% of original value
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.4m;        // 40% of original value
            }


            int age = CalculateApproximateAgeInYears();



            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
            }


            value = Decimal.Round(value, 0);    // round to the nearest pound         


            
            return value;
        }
    }
}


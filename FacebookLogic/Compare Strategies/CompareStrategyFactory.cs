using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic.Compare_Strategies
{
    public class CompareStrategyFactory
    {
        public static object CreateStrategy(string i_ChosenStrategy = null)
        {
            object toReturn = null;
            if(i_ChosenStrategy == null || i_ChosenStrategy == "Create Time")
            {
                toReturn = new CreateTimeStrategy();
            }
            else if (i_ChosenStrategy == "Update Time")
            {
                toReturn = new UpdateTimeStrategy();
            }
            else if (i_ChosenStrategy == "Comments")
            {
                toReturn = new CommentsAmountStrategy();
            }

            return toReturn;
        }
    }
}

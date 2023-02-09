using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Compare_Strategies
{
    public class CreateTimeStrategy : ICompareStrategy
    {
        public bool NeedToSwap(Post i_Post1, Post i_Post2)
        {
            bool shouldSwap = false;

            if (i_Post1.CreatedTime.Value != null && i_Post2.CreatedTime.Value != null)
            {
                shouldSwap = i_Post1.CreatedTime.Value.CompareTo(i_Post2.CreatedTime.Value) > 0;
            }

            return shouldSwap;
        }
    }
}

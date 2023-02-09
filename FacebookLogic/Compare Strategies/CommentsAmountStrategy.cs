using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Compare_Strategies
{
    public class CommentsAmountStrategy : ICompareStrategy
    {
        public bool NeedToSwap(Post i_post1, Post i_post2)
        {
            return i_post1.Comments.Count.CompareTo(i_post2.Comments.Count) <= 0;
        }
    }
}

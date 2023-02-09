using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public interface ICompareStrategy
    {
         bool NeedToSwap(Post i_Post1, Post i_Post2);
    }
}

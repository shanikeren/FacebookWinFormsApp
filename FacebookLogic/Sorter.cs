using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class Sorter
    {
        public ICompareStrategy Comparer { get; set; }

        public Sorter(ICompareStrategy i_Comparer)
        {
            Comparer = i_Comparer;
        }

        public void Sort(List<Post> io_PostsList)
        {
            for (int i = 0; i < io_PostsList.Count - 1; i++)
            {
                for (int j = 0; j < io_PostsList.Count - i - 1; j++)
                {
                    if (Comparer.NeedToSwap(io_PostsList[i], io_PostsList[j]))
                    {
                        swap(io_PostsList, i, j);
                    }
                }
            }
        }

        private void swap(List<Post> i_PostsList, int i_First, int i_Second)
        {
            Post tempPost = i_PostsList[i_First];
            i_PostsList[i_First] = i_PostsList[i_Second];
            i_PostsList[i_Second] = tempPost;
        }
    }
}

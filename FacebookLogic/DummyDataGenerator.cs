using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class DummyDataGenerator
    {
        private static Random m_Random;
        private static HashSet<String> m_GeneratedAlbums;

        public DummyDataGenerator()
        {
            m_GeneratedAlbums = new HashSet<string>();
            m_Random = new Random();
        }
       
        public void GenerateDummyTopRatedPictures(Album i_Album)
        {
            if(m_GeneratedAlbums.Contains(i_Album.Name) == false)
            {
                foreach (Photo img in i_Album.Photos)
                {
                    img.LikedBy = new FacebookObjectCollection<User>(m_Random.Next(151)); 
                    //TODO: might need to change the...
                }

                m_GeneratedAlbums.Add(i_Album.Name);
            }
            
        }
    }
}

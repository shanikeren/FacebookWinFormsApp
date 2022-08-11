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
        private  Random m_Random;
        private  Dictionary<String, List<(int, Photo)>> m_GeneratedAlbums;
        private HashSet<string> m_Generated;
        private readonly int k_AmountOfLikes = 11;

        public DummyDataGenerator()
        {
            m_GeneratedAlbums = new Dictionary<string, List<(int,Photo)>>();
            m_Generated = new HashSet<string>();
            m_Random = new Random();
        }
       
        public List<(int, Photo)> GenerateDummyTopRatedPictures(Album i_Album)
        {
            List<(int, Photo)> pictureWithLikes;
            bool isGenerated;
            isGenerated = m_GeneratedAlbums.TryGetValue(i_Album.Name, out pictureWithLikes);
            if(isGenerated == false)
            {
                int amountOfLike;
                pictureWithLikes = new List<(int, Photo)>();
                foreach (Photo img in i_Album.Photos)
                {
                    amountOfLike = m_Random.Next(101);
                    img.LikedBy = new FacebookObjectCollection<User>();
                    pictureWithLikes.Add((amountOfLike, img));
                }

                m_GeneratedAlbums.Add(i_Album.Name, pictureWithLikes);
            }

            return pictureWithLikes;
        }

        public List<Photo> GenerateDummyTopRatedPictures_WithUSER(Album i_Album)
        {
            bool isGenerated;

            isGenerated = m_Generated.Contains(i_Album.Name);
            if (isGenerated == false)
            {
                int amountOfLike;              
                foreach (Photo img in i_Album.Photos)
                {
                    amountOfLike = m_Random.Next(k_AmountOfLikes);
                    for(int i = 0; i < amountOfLike; i++)
                    {
                        img.LikedBy.Add(new User());
                    }
                }

                m_Generated.Add(i_Album.Name);
            }

            return i_Album.Photos.ToList();
        }
    }
}

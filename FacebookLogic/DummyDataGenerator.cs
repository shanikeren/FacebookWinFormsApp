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
        private List<(string, DateTime)> m_dummyEvents;



        public List<DummyUser> m_Friends { get; set; }
        public List<MyLocation> m_Location{ get ;set; }

        public DummyDataGenerator()
        {
            m_GeneratedAlbums = new Dictionary<string, List<(int,Photo)>>();
            m_Generated = new HashSet<string>();
            m_Random = new Random();
            m_Location = new List<MyLocation>();
            m_dummyEvents = new List<(string, DateTime)>();
            CreateCheckins();
            InitFriends();
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

        public List<(string, DateTime)> GenerateDummyEvents()
        {
            if(m_dummyEvents.Count == 0)
            {
                
                m_dummyEvents.Add(("Movie Night",new DateTime (2023, 5, 6)));
                m_dummyEvents.Add(("Wedding", new DateTime(2021, 1, 22)));
                m_dummyEvents.Add(("Breakfast with Mom", new DateTime(2022, 9, 5)));
                m_dummyEvents.Add(("Family vacation!", new DateTime(2022, 10, 10)));
                m_dummyEvents.Add(("Apocalypse", new DateTime(2012, 12, 12)));
                                
            }
            return m_dummyEvents;
        }

        public void ClearLoctions()
        {
            foreach(MyLocation cuurLoc in m_Location)
            {
                cuurLoc.m_AmountVisit = 0;
            }
        }

        public void CreateCheckins()
        {
            m_Location.Add(new MyLocation("Tel Aviv"));
            m_Location.Add(new MyLocation("Rome"));
            m_Location.Add(new MyLocation("Ramat Gan"));
            m_Location.Add(new MyLocation("Nesher"));
            m_Location.Add(new MyLocation("Omer"));
            m_Location.Add(new MyLocation("Nahariya"));
            m_Location.Add(new MyLocation("NoNoNo"));
            m_Location.Add(new MyLocation("Nisso"));
            m_Location.Add(new MyLocation("Aroma"));
            m_Location.Add(new MyLocation("Rosh HaNikra"));

            m_Location.Add(new MyLocation("Yes Planet"));
            m_Location.Add(new MyLocation("Zara"));
            m_Location.Add(new MyLocation("Kiso"));
            m_Location.Add(new MyLocation("Hadson"));
            m_Location.Add(new MyLocation("Gan Ner"));
            m_Location.Add(new MyLocation("Tel Aviv museum of art"));
            m_Location.Add(new MyLocation("Sun Yang"));
            m_Location.Add(new MyLocation("Hukok Beach"));
            m_Location.Add(new MyLocation("Cafe Cafe"));
            m_Location.Add(new MyLocation("Migdal"));

            m_Location.Add(new MyLocation("Big Tiberias"));
            m_Location.Add(new MyLocation("Gan HaShlosha National Park"));
            m_Location.Add(new MyLocation("Eilat"));
            m_Location.Add(new MyLocation("Taba"));
            m_Location.Add(new MyLocation("Shlomo Columns"));
            m_Location.Add(new MyLocation("Jerusalem"));
            m_Location.Add(new MyLocation("Madrid"));
            m_Location.Add(new MyLocation("Terner"));
            m_Location.Add(new MyLocation("Israel"));
            m_Location.Add(new MyLocation("Paris"));

        }

        public void InitFriends()
        {
            m_Friends = new List<DummyUser>();
    
            m_Friends.Add(new DummyUser("Or Elkabetz"));
            m_Friends.Add(new DummyUser("Gil Fishman"));
            m_Friends.Add(new DummyUser("Guy Yomtov"));
            m_Friends.Add(new DummyUser("Moshe Alfasi"));
            m_Friends.Add(new DummyUser("Alon Shakaroff"));
            m_Friends.Add(new DummyUser("Amit Leibovitch"));
            m_Friends.Add(new DummyUser("Snir Pinievsky"));
            m_Friends.Add(new DummyUser("Yoav Geva"));
            m_Friends.Add(new DummyUser("Omer Atar"));
            m_Friends.Add(new DummyUser("Ofir Bachar"));

            m_Friends.ElementAt(0).AddCheckin(m_Location.ElementAt(0).m_Name);
            m_Friends.ElementAt(0).AddCheckin(m_Location.ElementAt(5).m_Name);
            m_Friends.ElementAt(0).AddCheckin(m_Location.ElementAt(15).m_Name);
            m_Friends.ElementAt(0).AddCheckin(m_Location.ElementAt(23).m_Name);
            m_Friends.ElementAt(0).AddCheckin(m_Location.ElementAt(13).m_Name);
            m_Friends.ElementAt(0).AddCheckin(m_Location.ElementAt(8).m_Name);

            m_Friends.ElementAt(1).AddCheckin(m_Location.ElementAt(9).m_Name);
            m_Friends.ElementAt(1).AddCheckin(m_Location.ElementAt(0).m_Name);
            m_Friends.ElementAt(1).AddCheckin(m_Location.ElementAt(14).m_Name);
            m_Friends.ElementAt(1).AddCheckin(m_Location.ElementAt(22).m_Name);
            m_Friends.ElementAt(1).AddCheckin(m_Location.ElementAt(7).m_Name);

            m_Friends.ElementAt(2).AddCheckin(m_Location.ElementAt(28).m_Name);
            m_Friends.ElementAt(2).AddCheckin(m_Location.ElementAt(23).m_Name);
            m_Friends.ElementAt(2).AddCheckin(m_Location.ElementAt(26).m_Name);
            m_Friends.ElementAt(2).AddCheckin(m_Location.ElementAt(14).m_Name);
            m_Friends.ElementAt(2).AddCheckin(m_Location.ElementAt(1).m_Name);
            m_Friends.ElementAt(2).AddCheckin(m_Location.ElementAt(4).m_Name);
            m_Friends.ElementAt(2).AddCheckin(m_Location.ElementAt(5).m_Name);

            m_Friends.ElementAt(3).AddCheckin(m_Location.ElementAt(6).m_Name);
            m_Friends.ElementAt(3).AddCheckin(m_Location.ElementAt(5).m_Name);
            m_Friends.ElementAt(3).AddCheckin(m_Location.ElementAt(13).m_Name);
            m_Friends.ElementAt(3).AddCheckin(m_Location.ElementAt(25).m_Name);
            m_Friends.ElementAt(3).AddCheckin(m_Location.ElementAt(1).m_Name);
            m_Friends.ElementAt(3).AddCheckin(m_Location.ElementAt(8).m_Name);

            m_Friends.ElementAt(4).AddCheckin(m_Location.ElementAt(6).m_Name);
            m_Friends.ElementAt(4).AddCheckin(m_Location.ElementAt(7).m_Name);
            m_Friends.ElementAt(4).AddCheckin(m_Location.ElementAt(2).m_Name);
            m_Friends.ElementAt(4).AddCheckin(m_Location.ElementAt(0).m_Name);
            m_Friends.ElementAt(4).AddCheckin(m_Location.ElementAt(27).m_Name);

            m_Friends.ElementAt(5).AddCheckin(m_Location.ElementAt(13).m_Name);
            m_Friends.ElementAt(5).AddCheckin(m_Location.ElementAt(16).m_Name);
            m_Friends.ElementAt(5).AddCheckin(m_Location.ElementAt(0).m_Name);
            m_Friends.ElementAt(5).AddCheckin(m_Location.ElementAt(1).m_Name);
            m_Friends.ElementAt(5).AddCheckin(m_Location.ElementAt(11).m_Name);
            m_Friends.ElementAt(5).AddCheckin(m_Location.ElementAt(24).m_Name);

            m_Friends.ElementAt(6).AddCheckin(m_Location.ElementAt(0).m_Name);
            m_Friends.ElementAt(6).AddCheckin(m_Location.ElementAt(4).m_Name);
            m_Friends.ElementAt(6).AddCheckin(m_Location.ElementAt(6).m_Name);
            m_Friends.ElementAt(6).AddCheckin(m_Location.ElementAt(14).m_Name);
            m_Friends.ElementAt(6).AddCheckin(m_Location.ElementAt(13).m_Name);
            m_Friends.ElementAt(6).AddCheckin(m_Location.ElementAt(16).m_Name);

            m_Friends.ElementAt(7).AddCheckin(m_Location.ElementAt(14).m_Name);
            m_Friends.ElementAt(7).AddCheckin(m_Location.ElementAt(12).m_Name);
            m_Friends.ElementAt(7).AddCheckin(m_Location.ElementAt(2).m_Name);
            m_Friends.ElementAt(7).AddCheckin(m_Location.ElementAt(8).m_Name);
            m_Friends.ElementAt(7).AddCheckin(m_Location.ElementAt(5).m_Name);
            m_Friends.ElementAt(7).AddCheckin(m_Location.ElementAt(9).m_Name);

            m_Friends.ElementAt(8).AddCheckin(m_Location.ElementAt(9).m_Name);
            m_Friends.ElementAt(8).AddCheckin(m_Location.ElementAt(8).m_Name);
            m_Friends.ElementAt(8).AddCheckin(m_Location.ElementAt(7).m_Name);
            m_Friends.ElementAt(8).AddCheckin(m_Location.ElementAt(1).m_Name);
            m_Friends.ElementAt(8).AddCheckin(m_Location.ElementAt(6).m_Name);
            m_Friends.ElementAt(8).AddCheckin(m_Location.ElementAt(4).m_Name);

            m_Friends.ElementAt(9).AddCheckin(m_Location.ElementAt(13).m_Name);
            m_Friends.ElementAt(9).AddCheckin(m_Location.ElementAt(2).m_Name);
            m_Friends.ElementAt(9).AddCheckin(m_Location.ElementAt(18).m_Name);
            m_Friends.ElementAt(9).AddCheckin(m_Location.ElementAt(23).m_Name);
            m_Friends.ElementAt(9).AddCheckin(m_Location.ElementAt(15).m_Name);
            m_Friends.ElementAt(9).AddCheckin(m_Location.ElementAt(19).m_Name);

        }


    }

    public class MyLocation
    {
        public string m_Name { get; set; }
        public int m_AmountVisit { get; set; }
        public MyLocation(string name)
        {
            m_Name = name;
            m_AmountVisit = 0;
        }
    }
}

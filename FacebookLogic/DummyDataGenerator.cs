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
        private Random m_Random;
        private Dictionary<String, List<(int, Photo)>> m_GeneratedAlbums;
        private HashSet<string> m_Generated;
        private readonly int k_AmountOfLikes = 11;
        private List<(string, DateTime)> m_dummyEvents;
        public List<DummyUser> m_Friends { get; set; }
        public List<MyLocation> m_Location{ get ;set; }

        public DummyDataGenerator()
        {
            this.m_GeneratedAlbums = new Dictionary<string, List<(int, Photo)>>();
            this.m_Generated = new HashSet<string>();
            this.m_Random = new Random();
            this.m_Location = new List<MyLocation>();
            this.m_dummyEvents = new List<(string, DateTime)>();
            this.CreateCheckins();
            this.InitFriends();
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

        //public List<Photo> GenerateDummyTopRatedPictures_WithUSER(Album i_Album)
        //{
        //    bool isGenerated;

        //    isGenerated = m_Generated.Contains(i_Album.Name);
        //    if (isGenerated == false)
        //    {
        //        int amountOfLike;
        //        foreach (Photo img in i_Album.Photos)
        //        {
        //            amountOfLike = m_Random.Next(k_AmountOfLikes);
        //            for(int i = 0; i < amountOfLike; i++)
        //            {
        //                img.LikedBy.Add(new User());
        //            }
        //        }

        //        m_Generated.Add(i_Album.Name);
        //    }

        //    return i_Album.Photos.ToList();
        //}

        public List<(string, DateTime)> GenerateDummyEvents()
        {
            if(this.m_dummyEvents.Count == 0)
            {
                this.m_dummyEvents.Add(("Movie Night", new DateTime(2023, 5, 6)));
                this.m_dummyEvents.Add(("Wedding", new DateTime(2021, 1, 22)));
                this.m_dummyEvents.Add(("Breakfast with Mom", new DateTime(2022, 9, 5)));
                this.m_dummyEvents.Add(("Family vacation!", new DateTime(2022, 10, 10)));
                this.m_dummyEvents.Add(("Apocalypse", new DateTime(2012, 12, 12)));
            }

            return this.m_dummyEvents;
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
            this.m_Location.Add(new MyLocation("Tel Aviv"));
            this.m_Location.Add(new MyLocation("Rome"));
            this.m_Location.Add(new MyLocation("Ramat Gan"));
            this.m_Location.Add(new MyLocation("Nesher"));
            this.m_Location.Add(new MyLocation("Omer"));
            this.m_Location.Add(new MyLocation("Nahariya"));
            this.m_Location.Add(new MyLocation("NoNoNo"));
            this.m_Location.Add(new MyLocation("Nisso"));
            this.m_Location.Add(new MyLocation("Aroma"));
            this.m_Location.Add(new MyLocation("Rosh HaNikra"));

            this.m_Location.Add(new MyLocation("Yes Planet"));
            this.m_Location.Add(new MyLocation("Zara"));
            this.m_Location.Add(new MyLocation("Kiso"));
            this.m_Location.Add(new MyLocation("Hadson"));
            this.m_Location.Add(new MyLocation("Gan Ner"));
            this.m_Location.Add(new MyLocation("Tel Aviv museum of art"));
            this.m_Location.Add(new MyLocation("Sun Yang"));
            this.m_Location.Add(new MyLocation("Hukok Beach"));
            this.m_Location.Add(new MyLocation("Cafe Cafe"));
            this.m_Location.Add(new MyLocation("Migdal"));

            this.m_Location.Add(new MyLocation("Big Tiberias"));
            this.m_Location.Add(new MyLocation("Gan HaShlosha National Park"));
            this.m_Location.Add(new MyLocation("Eilat"));
            this.m_Location.Add(new MyLocation("Taba"));
            this.m_Location.Add(new MyLocation("Shlomo Columns"));
            this.m_Location.Add(new MyLocation("Jerusalem"));
            this.m_Location.Add(new MyLocation("Madrid"));
            this.m_Location.Add(new MyLocation("Terner"));
            this.m_Location.Add(new MyLocation("Israel"));
            this.m_Location.Add(new MyLocation("Paris"));
        }

        public void InitFriends()
        {
            this.m_Friends = new List<DummyUser>();
            this.m_Friends.Add(new DummyUser("Or Elkabetz"));
            this.m_Friends.Add(new DummyUser("Gil Fishman"));
            this.m_Friends.Add(new DummyUser("Guy Yomtov"));
            this.m_Friends.Add(new DummyUser("Moshe Alfasi"));
            this.m_Friends.Add(new DummyUser("Alon Shakaroff"));
            this.m_Friends.Add(new DummyUser("Amit Leibovitch"));
            this.m_Friends.Add(new DummyUser("Snir Pinievsky"));
            this.m_Friends.Add(new DummyUser("Yoav Geva"));
            this.m_Friends.Add(new DummyUser("Omer Atar"));
            this.m_Friends.Add(new DummyUser("Ofir Bachar"));

            this.m_Friends.ElementAt(0).AddCheckin(this.m_Location.ElementAt(0).m_Name);
            this.m_Friends.ElementAt(0).AddCheckin(this.m_Location.ElementAt(5).m_Name);
            this.m_Friends.ElementAt(0).AddCheckin(this.m_Location.ElementAt(15).m_Name);
            this.m_Friends.ElementAt(0).AddCheckin(this.m_Location.ElementAt(23).m_Name);
            this.m_Friends.ElementAt(0).AddCheckin(this.m_Location.ElementAt(13).m_Name);
            this.m_Friends.ElementAt(0).AddCheckin(this.m_Location.ElementAt(13).m_Name);
            this.m_Friends.ElementAt(0).AddCheckin(this.m_Location.ElementAt(8).m_Name);

            this.m_Friends.ElementAt(1).AddCheckin(this.m_Location.ElementAt(9).m_Name);
            this.m_Friends.ElementAt(1).AddCheckin(this.m_Location.ElementAt(0).m_Name);
            this.m_Friends.ElementAt(1).AddCheckin(this.m_Location.ElementAt(14).m_Name);
            this.m_Friends.ElementAt(1).AddCheckin(this.m_Location.ElementAt(22).m_Name);
            this.m_Friends.ElementAt(1).AddCheckin(this.m_Location.ElementAt(7).m_Name);

            this.m_Friends.ElementAt(2).AddCheckin(this.m_Location.ElementAt(28).m_Name);
            this.m_Friends.ElementAt(2).AddCheckin(this.m_Location.ElementAt(23).m_Name);
            this.m_Friends.ElementAt(2).AddCheckin(this.m_Location.ElementAt(26).m_Name);
            this.m_Friends.ElementAt(2).AddCheckin(this.m_Location.ElementAt(14).m_Name);
            this.m_Friends.ElementAt(2).AddCheckin(this.m_Location.ElementAt(1).m_Name);
            this.m_Friends.ElementAt(2).AddCheckin(this.m_Location.ElementAt(4).m_Name);
            this.m_Friends.ElementAt(2).AddCheckin(this.m_Location.ElementAt(5).m_Name);

            this.m_Friends.ElementAt(3).AddCheckin(this.m_Location.ElementAt(6).m_Name);
            this.m_Friends.ElementAt(3).AddCheckin(this.m_Location.ElementAt(5).m_Name);
            this.m_Friends.ElementAt(3).AddCheckin(this.m_Location.ElementAt(13).m_Name);
            this.m_Friends.ElementAt(3).AddCheckin(this.m_Location.ElementAt(25).m_Name);
            this.m_Friends.ElementAt(3).AddCheckin(this.m_Location.ElementAt(1).m_Name);
            this.m_Friends.ElementAt(3).AddCheckin(this.m_Location.ElementAt(8).m_Name);

            this.m_Friends.ElementAt(4).AddCheckin(this.m_Location.ElementAt(6).m_Name);
            this.m_Friends.ElementAt(4).AddCheckin(this.m_Location.ElementAt(7).m_Name);
            this.m_Friends.ElementAt(4).AddCheckin(this.m_Location.ElementAt(2).m_Name);
            this.m_Friends.ElementAt(4).AddCheckin(this.m_Location.ElementAt(0).m_Name);
            this.m_Friends.ElementAt(4).AddCheckin(this.m_Location.ElementAt(27).m_Name);

            this.m_Friends.ElementAt(5).AddCheckin(this.m_Location.ElementAt(13).m_Name);
            this.m_Friends.ElementAt(5).AddCheckin(this.m_Location.ElementAt(16).m_Name);
            this.m_Friends.ElementAt(5).AddCheckin(this.m_Location.ElementAt(0).m_Name);
            this.m_Friends.ElementAt(5).AddCheckin(this.m_Location.ElementAt(1).m_Name);
            this.m_Friends.ElementAt(5).AddCheckin(this.m_Location.ElementAt(11).m_Name);
            this.m_Friends.ElementAt(5).AddCheckin(this.m_Location.ElementAt(24).m_Name);

            this.m_Friends.ElementAt(6).AddCheckin(this.m_Location.ElementAt(0).m_Name);
            this.m_Friends.ElementAt(6).AddCheckin(this.m_Location.ElementAt(4).m_Name);
            this.m_Friends.ElementAt(6).AddCheckin(this.m_Location.ElementAt(6).m_Name);
            this.m_Friends.ElementAt(6).AddCheckin(this.m_Location.ElementAt(14).m_Name);
            this.m_Friends.ElementAt(6).AddCheckin(this.m_Location.ElementAt(13).m_Name);
            this.m_Friends.ElementAt(6).AddCheckin(this.m_Location.ElementAt(16).m_Name);

            this.m_Friends.ElementAt(7).AddCheckin(this.m_Location.ElementAt(14).m_Name);
            this.m_Friends.ElementAt(7).AddCheckin(this.m_Location.ElementAt(12).m_Name);
            this.m_Friends.ElementAt(7).AddCheckin(this.m_Location.ElementAt(2).m_Name);
            this.m_Friends.ElementAt(7).AddCheckin(this.m_Location.ElementAt(8).m_Name);
            this.m_Friends.ElementAt(7).AddCheckin(this.m_Location.ElementAt(5).m_Name);
            this.m_Friends.ElementAt(7).AddCheckin(this.m_Location.ElementAt(9).m_Name);

            this.m_Friends.ElementAt(8).AddCheckin(this.m_Location.ElementAt(9).m_Name);
            this.m_Friends.ElementAt(8).AddCheckin(this.m_Location.ElementAt(8).m_Name);
            this.m_Friends.ElementAt(8).AddCheckin(this.m_Location.ElementAt(7).m_Name);
            this.m_Friends.ElementAt(8).AddCheckin(this.m_Location.ElementAt(1).m_Name);
            this.m_Friends.ElementAt(8).AddCheckin(this.m_Location.ElementAt(6).m_Name);
            this.m_Friends.ElementAt(8).AddCheckin(this.m_Location.ElementAt(4).m_Name);

            this.m_Friends.ElementAt(9).AddCheckin(this.m_Location.ElementAt(13).m_Name);
            this.m_Friends.ElementAt(9).AddCheckin(this.m_Location.ElementAt(2).m_Name);
            this.m_Friends.ElementAt(9).AddCheckin(this.m_Location.ElementAt(18).m_Name);
            this.m_Friends.ElementAt(9).AddCheckin(this.m_Location.ElementAt(23).m_Name);
            this.m_Friends.ElementAt(9).AddCheckin(this.m_Location.ElementAt(15).m_Name);
            this.m_Friends.ElementAt(9).AddCheckin(this.m_Location.ElementAt(19).m_Name);
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

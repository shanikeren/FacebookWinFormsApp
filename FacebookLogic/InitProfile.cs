using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace FacebookLogic
{
    public class InitProfile
    {
        private User m_LoggedInUser;
        private List<string> m_AddedPosts;
        private string m_CurrentProfilePictureUrl { get; set; }

        
        private List<DummyUser> friends;
        
        public InitProfile(LoginResult i_loginResult)
        {
            m_LoggedInUser = i_loginResult.LoggedInUser;
            m_CurrentProfilePictureUrl = m_LoggedInUser.PictureNormalURL;
            m_AddedPosts = new List<string>();
        }

        public void InitFriends()
        {
            friends = new List<DummyUser>();
            List<string> location = CreateCheckins();
            friends.Add(new DummyUser("Or Elkabetz"));
            friends.Add(new DummyUser("Gil Fishman"));
            friends.Add(new DummyUser("Guy Yomtov"));
            friends.Add(new DummyUser("Moshe Alfasi"));
            friends.Add(new DummyUser("Alon Shakaroff"));
            friends.Add(new DummyUser("Amit Leibovitch"));
            friends.Add(new DummyUser("Snir Pinievsky"));
            friends.Add(new DummyUser("Yoav Geva"));
            friends.Add(new DummyUser("Omer Atar"));
            friends.Add(new DummyUser("Ofir Bachar"));

            friends.ElementAt(0).AddCheckin(location.ElementAt(0));
            friends.ElementAt(0).AddCheckin(location.ElementAt(5));
            friends.ElementAt(0).AddCheckin(location.ElementAt(15));
            friends.ElementAt(0).AddCheckin(location.ElementAt(23));
            friends.ElementAt(0).AddCheckin(location.ElementAt(13));
            friends.ElementAt(0).AddCheckin(location.ElementAt(8));

            friends.ElementAt(1).AddCheckin(location.ElementAt(9));
            friends.ElementAt(1).AddCheckin(location.ElementAt(0));
            friends.ElementAt(1).AddCheckin(location.ElementAt(14));
            friends.ElementAt(1).AddCheckin(location.ElementAt(22));
            friends.ElementAt(1).AddCheckin(location.ElementAt(7));

            friends.ElementAt(2).AddCheckin(location.ElementAt(28));
            friends.ElementAt(2).AddCheckin(location.ElementAt(23));
            friends.ElementAt(2).AddCheckin(location.ElementAt(26));
            friends.ElementAt(2).AddCheckin(location.ElementAt(14));
            friends.ElementAt(2).AddCheckin(location.ElementAt(1));
            friends.ElementAt(2).AddCheckin(location.ElementAt(4));
            friends.ElementAt(2).AddCheckin(location.ElementAt(5));

            friends.ElementAt(3).AddCheckin(location.ElementAt(6));
            friends.ElementAt(3).AddCheckin(location.ElementAt(5));
            friends.ElementAt(3).AddCheckin(location.ElementAt(13));
            friends.ElementAt(3).AddCheckin(location.ElementAt(25));
            friends.ElementAt(3).AddCheckin(location.ElementAt(1));
            friends.ElementAt(3).AddCheckin(location.ElementAt(8));

            friends.ElementAt(4).AddCheckin(location.ElementAt(6));
            friends.ElementAt(4).AddCheckin(location.ElementAt(7));
            friends.ElementAt(4).AddCheckin(location.ElementAt(2));
            friends.ElementAt(4).AddCheckin(location.ElementAt(0));
            friends.ElementAt(4).AddCheckin(location.ElementAt(27));

            friends.ElementAt(5).AddCheckin(location.ElementAt(13));
            friends.ElementAt(5).AddCheckin(location.ElementAt(16));
            friends.ElementAt(5).AddCheckin(location.ElementAt(0));
            friends.ElementAt(5).AddCheckin(location.ElementAt(1));
            friends.ElementAt(5).AddCheckin(location.ElementAt(11));
            friends.ElementAt(5).AddCheckin(location.ElementAt(24));

            friends.ElementAt(6).AddCheckin(location.ElementAt(0));
            friends.ElementAt(6).AddCheckin(location.ElementAt(4));
            friends.ElementAt(6).AddCheckin(location.ElementAt(6));
            friends.ElementAt(6).AddCheckin(location.ElementAt(14));
            friends.ElementAt(6).AddCheckin(location.ElementAt(13));
            friends.ElementAt(6).AddCheckin(location.ElementAt(16));

            friends.ElementAt(7).AddCheckin(location.ElementAt(14));
            friends.ElementAt(7).AddCheckin(location.ElementAt(12));
            friends.ElementAt(7).AddCheckin(location.ElementAt(2));
            friends.ElementAt(7).AddCheckin(location.ElementAt(8));
            friends.ElementAt(7).AddCheckin(location.ElementAt(5));
            friends.ElementAt(7).AddCheckin(location.ElementAt(9));

        }

        public List<string> CreateCheckins()
        {
            List<string> result = new List<string>();
            result.Add("Tel Aviv");
            result.Add("Rome");
            result.Add("Ramat Gan");
            result.Add("Nesher");
            result.Add("Omer");
            result.Add("Nahariya");
            result.Add("NoNoNo");
            result.Add("Nisso");
            result.Add("Aroma");
            result.Add("Rosh HaNikra");

            result.Add("Yes Planet");
            result.Add("Zara");
            result.Add("Kiso");
            result.Add("Hadson");
            result.Add("Gan Ner");
            result.Add("Tel Aviv museum of art");
            result.Add("Sun Yang");
            result.Add("Hukok Beach");
            result.Add("Cafe Cafe");
            result.Add("Migdal");

            result.Add("Big Tiberias");
            result.Add("Gan HaShlosha National Park");
            result.Add("Eilat");
            result.Add("Taba");
            result.Add("Shlomo Columns");
            result.Add("Jerusalem");
            result.Add("Madrid");
            result.Add("Terner");
            result.Add("Israel");
            result.Add("Paris");

            return result;
        }
        public string FetchProfilePicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public List<string> LoadPosts()
        {
            /* TODO: don't we want to see here only postposts.
             * eType = status
             * Or alternative - hendel each post as it should be handeld (e.g: photo-picBox...)
             * Or an optin to filter by post eType.
             * 
            */
            List<string> result = new List<string>();
            foreach (string post in m_AddedPosts)
            {
                result.Add(post);
            }

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                   result.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                   result.Add(post.Caption);
                }
            }

            

            return result;
        }

        

        public List<string> LoadEvents()
        {
            List<string> result = new List<string>();

            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                result.Add(fbEvent.Name);
            }

            return result;
        }

        public string getUpcomingEvent()
        {
            //Event upcomingEvent = m_LoggedInUser.Events.ElementAt(0);
            //return $"{upcomingEvent.Name} at: {upcomingEvent.TimeString}";
            return "Cant fetch events....";
        }

        public List<string> LoadGroups()
        {
            List<string> result = new List<string>();
            
            foreach (Group group in m_LoggedInUser.Groups)
            {
                result.Add(group.Name);
            }

            return result;
        }


        public List<string> LoadPages()
        {
            List<string> result = new List<string>();

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                result.Add(page.Name);
            }

            return result;
        }

        public List<(string, Image)> LoadAlbums()
        {
            List<(string, Image)> albumList = new List<(string, Image)>();

            foreach (Album album in m_LoggedInUser.Albums)
            {
                albumList.Add((album.Name, album.ImageAlbum));
            }

            return albumList;
        }

        public List<string> FetchAlbum(string i_AlbumName)
        {
            List<string> albumPics = new List<string>();

            foreach(Album album in m_LoggedInUser.Albums)
            {
                if(album.Name == i_AlbumName)
                {
                    foreach(Photo img in album.Photos)
                    {
                        albumPics.Add(img.PictureNormalURL);
                    }
                    break;
                }
            }

            return albumPics;
        }


        private List<Location> GetCheckIn()
        {
            List<Location> result = new List<Location>();
            foreach (Post post in m_LoggedInUser.Posts)
            {
                ///check enum compare with == or equals
               if(post.Type == Post.eType.checkin)
                {
                    result.Add(post.Place.Location);
                }
            }
            return result;
        }

        public void PostStatus(string i_Post)
        {
            m_AddedPosts.Insert(0,i_Post);
        }

        public List<string> needToVisitPlaces()
        {
            List<string> result = new List<string>();
            //List<Location> checkIns = GetCheckIn();
            List<Checkin> checkIns = m_LoggedInUser.Checkins.ToList(); 
            int max = 0;
            int lastIndex = checkIns.Count - 1;

            while(max < 5)
            {
                if (lastIndex >= 0)
                {
                    result.Add(checkIns.ElementAt(lastIndex).Place.Name);
                    lastIndex--;
                }
                max++;
            }
        
            return result;
        }
    }
}

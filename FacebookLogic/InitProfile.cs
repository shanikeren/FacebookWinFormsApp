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
        private readonly DummyDataGenerator m_MyDummyDataGenerator;
        
        private string m_CurrentProfilePictureUrl { get; set; }

   
        
        public InitProfile(LoginResult i_loginResult)
        {
            m_LoggedInUser = i_loginResult.LoggedInUser;
            m_CurrentProfilePictureUrl = m_LoggedInUser.PictureNormalURL;
            m_AddedPosts = new List<string>();
            m_MyDummyDataGenerator = new DummyDataGenerator();
        //    m_LoggedInUser.FriendLists = m_MyDummyDataGenerator.m_Friends;
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

        public List<string> FetchTopRatedPictures(string i_AlbumName)
        {
            Album requesteAlbum = null;
            List<string> result = null;

            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name == i_AlbumName)
                {
                    requesteAlbum = album;
                    m_MyDummyDataGenerator.GenerateDummyTopRatedPictures(requesteAlbum);
                    break;
                }
            }

            //List<string> SortedList = m_LoggedInUser.Albums.Photos.OrderBy(a => a.LikedBy.Count).ToList();
            if(requesteAlbum != null)
            {
                List<Photo> SortedList = requesteAlbum.Photos.OrderBy(pic => pic.LikedBy).ToList();
                
                for (int i = SortedList.Count - 1; i >= 0 && i > SortedList.Count - 4; i-- )
                {
                    result.Add(SortedList.ElementAt(i).PictureNormalURL);
                }
            }
            return result;
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


        public List<string> FetchTopVisitPlaces()
        {
            List<string> result = null;

            foreach (DummyUser user in m_MyDummyDataGenerator.m_Friends)
            {
                foreach (string loaction in user.m_checkins)
                {
                    int index = GetLocationIndex(loaction);
                    m_MyDummyDataGenerator.m_Location.ElementAt(index).m_AmountVisit++;
                }
            }

            List<MyLocation> SortedList = m_MyDummyDataGenerator.m_Location.OrderBy(location => location.m_AmountVisit).ToList();
            SortedList.Reverse();

            for (int i = 0; i < 10 && i < SortedList.Count; i++)
            {
                result.Add(SortedList.ElementAt(i).m_Name);
            }
            return result;
        }

        public int GetLocationIndex(string i_LocationName)
        {
            int index = 0;
        
            foreach(MyLocation location in m_MyDummyDataGenerator.m_Location)
            {
                if (location.m_Name.EndsWith(i_LocationName))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

    }
}

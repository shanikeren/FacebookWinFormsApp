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


        private List<(string, DateTime)> LoadEvents()
        {
           return m_MyDummyDataGenerator.GenerateDummyEvents();
        }

        public string getUpcomingEvent()
        {
            string upcomingEvent = string.Empty;
            List<(string, DateTime)> eventsList = new List<(string, DateTime)>();
            eventsList = LoadEvents();
            //foreach (Event fbEvent in m_LoggedInUser.Events)
            //{
            //    eventsList.Add((fbEvent.Name, (DateTime)fbEvent.UpdateTime));
            //}

            eventsList.Sort(compareEvents);
            upcomingEvent = findNearestEvent(eventsList);

            return upcomingEvent;
        }

        private string findNearestEvent(List<(string, DateTime)> i_eventsList)
        {
            string upcomingEvent = string.Empty;
            DateTime currentDate = DateTime.Now.Date;

            foreach((string, DateTime) currEvent in i_eventsList)
            {
                if(currEvent.Item2.CompareTo(currentDate) >= 0)
                {
                    upcomingEvent = currEvent.Item1 +" at: " + currEvent.Item2.ToShortDateString();
                    break;
                }
            }

            return upcomingEvent;
        }

        private int compareEvents((string,DateTime) i_event1, (string,DateTime) i_event2)
        {
            return i_event1.Item2.CompareTo(i_event2.Item2);
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

        public delegate int Comparison<Photo>(Photo pic1, Photo pic2);

        public List<string> FetchTopRatedPictures_WithUserDummy(string i_AlbumName)
        {
            Album requesteAlbum = null;
            List<string> result = new List<string>();
            List<Photo> sortedDummyLikedByData;

            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name == i_AlbumName)
                {
                   requesteAlbum = album;
                   sortedDummyLikedByData =  m_MyDummyDataGenerator.GenerateDummyTopRatedPictures_WithUSER(album);
                    sortedDummyLikedByData.Sort(comparePhotoRating);

                    for (int i = sortedDummyLikedByData.Count - 1; i >= 0 && i > sortedDummyLikedByData.Count - 4; i--)
                    {
                        result.Add(sortedDummyLikedByData.ElementAt(i).PictureNormalURL);
                    }
                    break;
                }

                
            }

            return result;
        }

        public List<string> FetchTopRatedPictures(string i_AlbumName)
        {
            Album requesteAlbum = null;
            List<string> result = new List<string>();
            List<(int, Photo)> dummyLikedByData;

            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name == i_AlbumName)
                {
                    requesteAlbum = album;
                    dummyLikedByData = m_MyDummyDataGenerator.GenerateDummyTopRatedPictures(requesteAlbum);
                    dummyLikedByData.Sort(comparePhotoRating);
                    for (int i = dummyLikedByData.Count - 1; i >= 0 && i > dummyLikedByData.Count - 4; i--)
                    {
                        result.Add(dummyLikedByData.ElementAt(i).Item2.PictureNormalURL);
                    }
                    break;
                }
            }

            return result;
        }

        private int comparePhotoRating(Photo i_pic1, Photo i_pic2)
        {
            return i_pic1.LikedBy.Count.CompareTo(i_pic2.LikedBy.Count);
        }

        private int comparePhotoRating((int, Photo) x, (int, Photo) y)
        {
            return x.Item1.CompareTo(y.Item1);
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


        public List<(string,int)> FetchTopVisitPlaces()
        {
            List<(string,int)> result = new List<(string, int)>();
            m_MyDummyDataGenerator.ClearLoctions();

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
                result.Add((SortedList.ElementAt(i).m_Name, SortedList.ElementAt(i).m_AmountVisit));
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

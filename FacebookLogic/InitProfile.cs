using System;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic
{
    [Serializable]
    public class InitProfile
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult = null;
        private List<string> m_AddedPosts;

        public List<HangOutOffer> m_MyHangOuts { get; }

        private readonly AppSettings r_AppSettings;

        private readonly DummyDataGenerator r_MyDummyDataGenerator;

        private string m_CurrentProfilePictureUrl { get; set; }

        public InitProfile(LoginResult i_loginResult)
        {
            m_LoggedInUser = i_loginResult.LoggedInUser;
            m_CurrentProfilePictureUrl = m_LoggedInUser.PictureNormalURL;
            m_AddedPosts = new List<string>();
            m_MyHangOuts = new List<HangOutOffer>();
            r_MyDummyDataGenerator = new DummyDataGenerator();
        }

        public InitProfile()
        {
            r_AppSettings = AppSettings.Instance;
            r_MyDummyDataGenerator = new DummyDataGenerator();
            m_AddedPosts = new List<string>();
            m_MyHangOuts = new List<HangOutOffer>();
            r_AppSettings = AppSettings.Instance;
        }

        public LoginResult LogInFromXml()
        {
            m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            return m_LoginResult;
        }

        public string Name
        {
            get
            {
                return m_LoggedInUser.Name;
            }
        }

        public User LoggedUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        public string AccessToken
        {
            get
            {
                return m_LoginResult.AccessToken;
            }
        }

        public string FetchProfilePicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public List<Post> LoadPosts()
        {
            return m_LoggedInUser.Posts.ToList();
        }

        private List<(string, DateTime)> LoadEvents()
        {
            return r_MyDummyDataGenerator.GenerateDummyEvents();
        }

        public string GetUpcomingEvent()
        {
            string upcomingEvent = string.Empty;
            List<(string, DateTime)> eventsList = new List<(string, DateTime)>();
            eventsList = LoadEvents();

            eventsList.Sort(compareEvents);
            upcomingEvent = findNearestEvent(eventsList);

            return upcomingEvent;
        }

        public bool CheckIfLoggedIn(LoginResult i_LoginResult)
        {
            bool logedInSuccessfully = false;

            if (!string.IsNullOrEmpty(i_LoginResult.AccessToken))
            {
                m_LoginResult = i_LoginResult;
                m_LoggedInUser = i_LoginResult.LoggedInUser;
                logedInSuccessfully = true;
            }

            return logedInSuccessfully;
        }

        private string findNearestEvent(List<(string, DateTime)> i_eventsList)
        {
            string upcomingEvent = string.Empty;
            DateTime currentDate = DateTime.Now.Date;

            foreach ((string, DateTime) currEvent in i_eventsList)
            {
                if (currEvent.Item2.CompareTo(currentDate) >= 0)
                {
                    upcomingEvent = currEvent.Item1 + " at: " + currEvent.Item2.ToShortDateString();
                    break;
                }
            }

            return upcomingEvent;
        }

        private int compareEvents((string, DateTime) i_event1, (string, DateTime) i_event2)
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

        public void UpdateAppSettingsBeforeClose(bool i_RemeberMeChecked)
        {
            r_AppSettings.RememberUser = i_RemeberMeChecked;

            if (r_AppSettings.RememberUser)
            {
                if (m_LoginResult.LoggedInUser != null)
                {
                    r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                }
            }
            else
            {
                r_AppSettings.LastAccessToken = null;
            }

            r_AppSettings.SaveToFile();
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

            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name == i_AlbumName)
                {
                    foreach (Photo img in album.Photos)
                    {
                        albumPics.Add(img.PictureNormalURL);
                    }

                    break;
                }
            }

            return albumPics;
        }

        public delegate int Comparison<Photo>(Photo pic1, Photo pic2);

        public void OnProfilePictureChange(string i_Url)
        {
            m_CurrentProfilePictureUrl = i_Url;
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
                    dummyLikedByData = r_MyDummyDataGenerator.GenerateDummyTopRatedPictures(requesteAlbum);
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

        private int comparePhotoRating((int, Photo) x, (int, Photo) y)
        {
            return x.Item1.CompareTo(y.Item1);
        }

        public void PostStatus(string i_Post)
        {
            m_AddedPosts.Insert(0, i_Post);
        }

        public List<(string, int)> FetchTopVisitPlaces()
        {
            List<(string, int)> topVisitPlaces = new List<(string, int)>();
            this.r_MyDummyDataGenerator.ClearLoctions();

            foreach (DummyUser user in this.r_MyDummyDataGenerator.m_Friends)
            {
                foreach (string loaction in user.m_checkins)
                {
                    int index = GetLocationIndex(loaction);
                    this.r_MyDummyDataGenerator.m_Location.ElementAt(index).m_AmountVisit++;
                }
            }

            List<MyLocation> sortedList = r_MyDummyDataGenerator.m_Location.OrderBy(location => location.m_AmountVisit).ToList();
            sortedList.Reverse();

            for (int i = 0; i < 10 && i < sortedList.Count; i++)
            {
                topVisitPlaces.Add((sortedList.ElementAt(i).m_Name, sortedList.ElementAt(i).m_AmountVisit));
            }

            return topVisitPlaces;
        }

        public int GetLocationIndex(string i_LocationName)
        {
            int index = 0;
            foreach (MyLocation location in this.r_MyDummyDataGenerator.m_Location)
            {
                if (location.m_Name.EndsWith(i_LocationName))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        internal void AddOffer(HangOutOffer i_OfferToAdd)
        {
            m_MyHangOuts.Add(i_OfferToAdd);
        }
    }
}

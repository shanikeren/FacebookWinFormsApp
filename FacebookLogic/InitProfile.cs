﻿using FacebookWrapper;
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

        
        public InitProfile(LoginResult i_loginResult)
        {
            m_LoggedInUser = i_loginResult.LoggedInUser;
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

using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public List<string> LoadGroups()
        {
            List<string> result = new List<string>();
            
            foreach (Group group in m_LoggedInUser.Groups)
            {
                result.Add(group.Name);
            }

            return result;
        }




    }
}

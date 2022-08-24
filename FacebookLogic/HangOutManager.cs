using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public sealed class HangOutManager
    {
        private static HangOutManager s_Instance = null;
        private static readonly object sr_InstanceLock = new Object();

        private static List<HangOutOffer> AllOffers { get; set; }

        //static HangOutManager()
        //{
        //    s_AllOffers = new List<HangOutOffer>();
        //}

        private HangOutManager()
        {
            AllOffers = new List<HangOutOffer>();
        }

        public static HangOutManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new HangOutManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void AddOffer(List<string> i_HangOutDetails)
        {
            HangOutOffer newHangOut = new HangOutOffer();
            newHangOut.SetHangOutDetails(i_HangOutDetails);
            AllOffers.Add(newHangOut);
        }

        public void AddPasanger(HangOutOffer i_HanfOutOffer, string i_UserToAdd)
        {
            i_HanfOutOffer.AddPassanger(i_UserToAdd);
            if(i_HanfOutOffer.AvailableSeats == 0)
            {
                AllOffers.Remove(i_HanfOutOffer);
            }
        }

    }
}

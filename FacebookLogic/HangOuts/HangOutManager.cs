using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookLogic.Interfaces;

namespace FacebookLogic
{
    internal sealed class HangOutManager : IAggregate<HangOutOffer>
    {
        private static readonly object sr_InstanceLock = new object();
        private static HangOutManager s_Instance = null;

        public static List<HangOutOffer> AllOffers { get; set; }

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

        internal HangOutOffer AddOffer(List<string> i_HangOutDetails)
        {
            HangOutOffer newHangOut = new HangOutOffer();
            newHangOut.SetHangOutDetails(i_HangOutDetails);
            AllOffers.Add(newHangOut);
            return newHangOut;
        }

        public void AddOffer(HangOutOffer i_HangOutToAdd)
        {
            AllOffers.Add(i_HangOutToAdd);
        }

        public void AddPasanger(HangOutOffer i_HanfOutOffer, string i_UserToAdd)
        {
            i_HanfOutOffer.AddPassanger(i_UserToAdd);
            if(i_HanfOutOffer.AvailableSeats == 0)
            {
                AllOffers.Remove(i_HanfOutOffer);
            }
        }

        public List<HangOutOffer> GetOffersByPlace(string i_Place)
        {
            List<HangOutOffer> listByPlace = new List<HangOutOffer>();

            foreach(HangOutOffer offer in AllOffers)
            {
                if(offer.WhereTo == i_Place)
                {
                    listByPlace.Add(offer);
                }
            }

            return listByPlace;
        }

        public IIterator<HangOutOffer> CreateIterator()
        {
            return new HangOutIterator();
        }

        private class HangOutIterator : IIterator<HangOutOffer>
        {
            private HangOutManager m_Agregate;
            private int m_CurrentIdx = -1;
            private int m_Count = -1;

            public HangOutIterator()
            {
                m_Agregate = HangOutManager.Instance;
                m_Count = HangOutManager.AllOffers.Count;
            }

            public HangOutOffer Current
            {
                get { return HangOutManager.AllOffers[m_CurrentIdx]; }
            }

            public bool MoveNext()
            {
                if (m_Count != HangOutManager.AllOffers.Count)
                {
                    throw new Exception("Collection can not be changed during iteration!");
                }

                if (m_CurrentIdx >= m_Count)
                {
                    throw new Exception("Already reached the end of the collection");
                }

                return ++m_CurrentIdx < HangOutManager.AllOffers.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = -1;
            }
        }
    }
}

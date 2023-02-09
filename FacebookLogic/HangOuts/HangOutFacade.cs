using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookLogic.Interfaces;

namespace FacebookLogic
{
    public sealed class HangOutFacade
    {
        private static HangOutFacade s_HangOutFacadeInstance = null;
        private readonly InitProfile m_LogedInUser;
        private readonly HangOutManager m_HangOutManager;

        public HangOutOffer CurrOffer { get; set; }

        public static HangOutFacade GetHangOutFacade(InitProfile i_LogedInUser)
        {
            if(s_HangOutFacadeInstance == null)
            {
                s_HangOutFacadeInstance = new HangOutFacade(i_LogedInUser);
            }

            return s_HangOutFacadeInstance;
        }

        private HangOutFacade(InitProfile i_LogedInUser)
        {
            m_LogedInUser = i_LogedInUser;
            CurrOffer = new HangOutOffer();
            m_HangOutManager = HangOutManager.Instance;
            DummyDataGenerator.InitHangOutOffers();
        }

        public void JoinHangOut()
        {
            m_HangOutManager.AddPasanger(CurrOffer, m_LogedInUser.Name);
            m_LogedInUser.AddOffer(CurrOffer);
        }

        public void CreateHangOut()
        {
            HangOutOffer newOffer = ClassesCloneMachine.Clone(CurrOffer);
            m_HangOutManager.AddOffer(newOffer);
            m_LogedInUser.AddOffer(newOffer);
        }

        public List<HangOutOffer> GetAllOffers()
        {
            return HangOutManager.AllOffers;
        }

        public List<HangOutOffer> GetOffersByPlace(string i_Place)
        {
            return m_HangOutManager.GetOffersByPlace(i_Place);
        }

        public List<HangOutOffer> GetOffersByTime(DateTime i_FromTime, DateTime i_UntilTime)
        {
            List<HangOutOffer> timeFilteredOffers = new List<HangOutOffer>();
            HangOutOffer currentOffer;
            IIterator<HangOutOffer> offersIterator = m_HangOutManager.CreateIterator();

            while(offersIterator.MoveNext())
            {
                currentOffer = offersIterator.Current;

                if (currentOffer.When.Date <= i_UntilTime.Date && currentOffer.When.Date >= i_FromTime.Date)
                {
                    timeFilteredOffers.Add(currentOffer);
                }
            }

            return timeFilteredOffers;
        }
    }
}
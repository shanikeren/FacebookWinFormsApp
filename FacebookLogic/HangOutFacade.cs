using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class HangOutFacade
    {
        private readonly InitProfile m_LogedInUser;
        private readonly HangOutManager m_HangOutManager;
        public HangOutOffer CurrOffer { get; set; }
        // serilizer?

        public HangOutFacade(InitProfile i_LogedInUser)
        {
            m_LogedInUser = i_LogedInUser;
            CurrOffer = new HangOutOffer();
            m_HangOutManager = HangOutManager.Instance;
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
            return HangOutManager.AllOffers;
        }

    }
}

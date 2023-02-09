using System.Threading.Tasks;
using System.Text;
using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    [Serializable]
    public class HangOutOffer
    {
        public InitProfile Initiator { get; set; }

        public string WhereTo { get; set; }

        public string InitiatorName { get; set; }

        public string InitiatorPhone { get; set; }

        public string FromWhere { get; set; }

        public string LeavingTime { get; set; }

        public DateTime When { get; set; }

        public List<string> RidePassengers { get; set; }

        public int MaxCarPassengers { get; set; }

        public HangOutOffer()
        {
            RidePassengers = new List<string>();
        }

        public int AvailableSeats
        {
            get { return this.MaxCarPassengers - this.RidePassengers.Count; }
        }

        internal void AddPassanger(string i_PassangerName)
        {
            if (this.RidePassengers.Count < this.MaxCarPassengers)
            {
                this.RidePassengers.Add(i_PassangerName);
            }
            else
            {
                throw new Exception("Sorry, this ride is full. Join by your own, or try another one:)");
            }
        }

        internal void SetHangOutDetails(List<string> i_HangOutDetails)
        {
            this.InitiatorName = i_HangOutDetails[0];
            this.InitiatorPhone = i_HangOutDetails[1];
            this.FromWhere = i_HangOutDetails[2];
            this.WhereTo = i_HangOutDetails[3];
            this.MaxCarPassengers = int.Parse(i_HangOutDetails[4]);
            this.LeavingTime = i_HangOutDetails[5];
            this.When = Convert.ToDateTime(this.LeavingTime);
        }

        public override string ToString()
        {
            return string.Format("To {0}, at {1}", this.WhereTo, this.When);
        }
    }
}

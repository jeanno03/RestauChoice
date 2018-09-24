using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class Vote
    {
        public int VoteId { get; set; }
        public DateTime VoteDate { get; set; }
        public int Voix { get; set; }
        public virtual TheUser TheUser { get; set; }
        public virtual Evenement Evenement { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        public Vote()
        {
        }

        public Vote(DateTime voteDate, int voix)
        {
            VoteDate = voteDate;
            Voix = voix;
        }
    }
}
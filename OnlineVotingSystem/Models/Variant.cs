using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public class Variant
    {
        public int Id { get; set; }
        public int VotingId { get; set; }
        public string Text { get; set; }

        public ICollection<Voice> Voices { get; set; }
        public Variant()
        {
            Voices = new List<Voice>();
        }

        public Voting Voting { get; set; }
    }
}
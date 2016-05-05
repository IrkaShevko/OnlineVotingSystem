using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int VotingId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Voting Voting { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public class Voting
    {
        public int Id { get; set; }
        public int State { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime LastActivityDate { get; set; }
        public int LastActivityUser { get; set; }

        public ICollection<Variant> Variants { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public Voting()
        {
            Variants = new List<Variant>();
            Comments = new List<Comment>();
        }

        public User User { get; set; }
    }
}
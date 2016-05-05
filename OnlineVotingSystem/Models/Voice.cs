using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public class Voice
    {
        public int Id { get; set; }
        public int VariantId { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }

        public Variant Variant { get; set; }
    }
}
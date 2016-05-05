using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsBlocked { get; set; }
        public ICollection<Voting> Votings { get; set; }
        public ICollection<Voice> Voices { get; set; }
        public ICollection<Role> Roles { get; set; }
        public User()
        {
            Votings = new List<Voting>();
            Voices = new List<Voice>();
            Roles = new List<Role>();
        }

    }
}
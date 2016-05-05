using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models.ViewModels
{
    public class IndexUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
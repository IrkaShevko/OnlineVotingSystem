using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public enum State
    {
        Active = 1,
        Closed,
        Blocked,
        OnCheck
    }
}
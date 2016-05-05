using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.BLL.Interfaces
{
    public interface IVotingService
    {
        void AddVoting(string description);
        void SetState(int stateId);
        void DeleteVoting(int id);
        IEnumerable<Voting> GetAllVotings();
    }
}

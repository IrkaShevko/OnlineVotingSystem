using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.BLL.Interfaces
{
    public interface IVariantService
    {
        void AddVariant(string text, int votingId);
    }
}

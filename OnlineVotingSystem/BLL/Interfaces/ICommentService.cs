using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineVotingSystem.BLL.Interfaces
{
    public interface ICommentService
    {
        void AddComment(string text);
        void DeleteComment(int id);
    }
}

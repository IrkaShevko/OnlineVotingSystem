using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.BLL
{
    public interface IUserService
    {
        void Login(string email, string password);
        void Register(User item);
        IEnumerable<User> GetAllUsers();
    }
}

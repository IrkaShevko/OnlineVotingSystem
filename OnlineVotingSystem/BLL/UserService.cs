using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.BLL
{
    public class UserService: IUserService
    {
        private IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(User item)
        {
            _repository.Create(item);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAll();
        }
    }
}
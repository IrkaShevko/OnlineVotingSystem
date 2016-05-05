using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineVotingSystem.BLL.Interfaces;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.BLL
{
    public class RoleService: IRoleService
    {
        private IRepository<Role> _repository;

        public RoleService(IRepository<Role> repository)
        {
            _repository = repository;
        }
        public void AddRole(string name)
        {
            _repository.Create(new Role() {Name = name});
        }

        public void DeleteRole(int id)
        {
            _repository.Delete(id);
        }
    }
}
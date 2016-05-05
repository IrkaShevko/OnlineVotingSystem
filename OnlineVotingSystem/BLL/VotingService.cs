using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineVotingSystem.BLL.Interfaces;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.BLL
{
    public class VotingService:IVotingService
    {
        private IRepository<Voting> _repository;

        public VotingService(IRepository<Voting> repository)
        {
            _repository = repository;
        }
        public void AddVoting(string description)
        {
            _repository.Create(new Voting() {Description = description});
        }

        public void SetState(int stateId)
        {
            throw new NotImplementedException();
        }

        public void DeleteVoting(int id)
        {
            _repository.Delete(id);
        }
        public IEnumerable<Voting> GetAllVotings()
        {
            return _repository.GetAll();
        }
    }
}
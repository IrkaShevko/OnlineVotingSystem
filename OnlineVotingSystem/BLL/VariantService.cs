using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineVotingSystem.BLL.Interfaces;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.BLL
{
    public class VariantService:IVariantService
    {
        private IRepository<Variant> _repository;

        public VariantService(IRepository<Variant> repository)
        {
            _repository = repository;
        }

        public void AddVariant(string text, int votingId)
        {
            _repository.Create(new Variant() {Text = text, VotingId = votingId});
        }
    }
}
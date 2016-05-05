using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineVotingSystem.BLL.Interfaces;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.BLL
{
    public class VoiceService : IVoiceService
    {
        private IRepository<Voice> _repository;

        public VoiceService(IRepository<Voice> repository)
        {
            _repository = repository;
        }
        public void Vote(int userId, int variantId)
        {
            _repository.Create(new Voice() {VariantId = variantId, UserId = userId});
        }
    }
}
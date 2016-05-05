using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Repository
{
    public class VotingRepository: IRepository<Voting>
    {
        private SystemContext db;

        public VotingRepository(SystemContext context)
        {
            this.db = context;
        }

        public IEnumerable<Voting> GetAll()
        {
            return db.Votings.Include(o => o.User);
        }

        public Voting Get(int id)
        {
            return db.Votings.Find(id);
        }

        public void Create(Voting voting)
        {
            db.Votings.Add(voting);
        }

        public void Update(Voting voting)
        {
            db.Entry(voting).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Voting voting = db.Votings.Find(id);
            if (voting != null)
                db.Votings.Remove(voting);
        }
    }
}
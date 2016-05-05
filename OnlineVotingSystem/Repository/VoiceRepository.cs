using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Repository
{
    public class VoiceRepository : IRepository<Voice>
    {
        private SystemContext db;

        public VoiceRepository(SystemContext context)
        {
            this.db = context;
        }

        public IEnumerable<Voice> GetAll()
        {
            return db.Voices.Include(o => o.Variant);
        }

        public Voice Get(int id)
        {
            return db.Voices.Find(id);
        }

        public void Create(Voice voice)
        {
            db.Voices.Add(voice);
        }

        public void Update(Voice voice)
        {
            db.Entry(voice).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Voice voice = db.Voices.Find(id);
            if (voice != null)
                db.Voices.Remove(voice);
        }
    }
}
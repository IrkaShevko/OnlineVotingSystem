using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Repository
{
    public class VariantRepository : IRepository<Variant>
    {
        private SystemContext db;

        public VariantRepository(SystemContext context)
        {
            this.db = context;
        }

        public IEnumerable<Variant> GetAll()
        {
            return db.Variants.Include(o => o.Voting);
        }

        public Variant Get(int id)
        {
            return db.Variants.Find(id);
        }

        public void Create(Variant variant)
        {
            db.Variants.Add(variant);
        }

        public void Update(Variant variant)
        {
            db.Entry(variant).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Variant variant = db.Variants.Find(id);
            if (variant != null)
                db.Variants.Remove(variant);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Repository
{
    public class RoleRepository : IRepository<Role>
    {
        private SystemContext db;

        public RoleRepository(SystemContext context)
        {
            this.db = context;
        }

        public IEnumerable<Role> GetAll()
        {
            return db.Roles;
        }

        public Role Get(int id)
        {
            return db.Roles.Find(id);
        }

        public void Create(Role role)
        {
            db.Roles.Add(role);
        }

        public void Update(Role role)
        {
            db.Entry(role).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Role role = db.Roles.Find(id);
            if (role != null)
                db.Roles.Remove(role);
        }
    }
}
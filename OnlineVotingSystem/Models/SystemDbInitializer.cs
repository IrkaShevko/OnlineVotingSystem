using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public class SystemDbInitializer: DropCreateDatabaseIfModelChanges<SystemContext>
    {
        protected override void Seed(SystemContext db)
        {
            db.Users.Add(new User { Email = "Tom@tom.com"});
            db.Users.Add(new User { Email = "Sam@tom.com" });
            db.Users.Add(new User { Email = "John@tom.com" });

            base.Seed(db);
        }
    }
}
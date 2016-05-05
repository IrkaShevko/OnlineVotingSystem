using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Repository
{
    public class UnitOfWork : IDisposable
    {
        private SystemContext db = new SystemContext();
        private UserRepository userRepository;
        private RoleRepository roleRepository;
        private VotingRepository votingRepository;
        private VoiceRepository voiceRepository;
        private VariantRepository variantRepository;
        private CommentRepository commentRepository;

        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public RoleRepository Roles
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new RoleRepository(db);
                return roleRepository;
            }
        }
        public VotingRepository Votings
        {
            get
            {
                if (votingRepository == null)
                    votingRepository = new VotingRepository(db);
                return votingRepository;
            }
        }
        public VoiceRepository Voices
        {
            get
            {
                if (voiceRepository == null)
                    voiceRepository = new VoiceRepository(db);
                return voiceRepository;
            }
        }
        public VariantRepository Variants
        {
            get
            {
                if (variantRepository == null)
                    variantRepository = new VariantRepository(db);
                return variantRepository;
            }
        }
        public CommentRepository Comment
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(db);
                return commentRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
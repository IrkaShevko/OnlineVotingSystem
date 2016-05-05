using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineVotingSystem.BLL.Interfaces;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.BLL
{
    public class CommentService: ICommentService
    {
        private IRepository<Comment> _repository;

        public CommentService(IRepository<Comment> repository)
        {
            _repository = repository;
        }
        public void AddComment(string text)
        {
            _repository.Create(new Comment() {Text = text, Date = DateTime.Now});
        }

        public void DeleteComment(int id)
        {
            _repository.Delete(id);
        }
    }
}
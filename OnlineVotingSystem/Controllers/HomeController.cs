using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineVotingSystem.Models;
using System.Data.Entity;
using AutoMapper;
using OnlineVotingSystem.BLL;
using OnlineVotingSystem.BLL.Interfaces;
using OnlineVotingSystem.Models.ViewModels;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        private readonly IVotingService _service;
        public HomeController(IVotingService service)
        {
            unitOfWork = new UnitOfWork();
            _service = service;
        }
        public ActionResult Index()
        {
            Mapper.CreateMap<Voting, IndexVotingViewModel>();
            // сопоставление
            var votings =
                Mapper.Map<IEnumerable<Voting>, List<IndexVotingViewModel>>(_service.GetAllVotings());
            return View(votings);
        }

        public ActionResult AboutMe()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}
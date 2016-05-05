using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using OnlineVotingSystem.BLL;
using OnlineVotingSystem.Models;
using OnlineVotingSystem.Models.ViewModels;
using OnlineVotingSystem.Repository;

namespace OnlineVotingSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _service;
        public AccountController(IUserService service)
        {
            _service = service;
        }
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View(new RegisterUserViewModel());
        }
        [HttpPost]
        public ActionResult Register(RegisterUserViewModel model)
        {
            try
            {
                Mapper.CreateMap<RegisterUserViewModel, User>()
                    .ForMember("Email", opt => opt.MapFrom(c => c.Email))
                    .ForMember("Password", opt => opt.MapFrom(src => src.Password))
                    .ForMember("BirthDate", opt => opt.MapFrom(src => src.BirthDate));
                // Выполняем сопоставление
                User user = Mapper.Map<RegisterUserViewModel, User>(model);
                _service.Register(user);
                return Redirect("/Home/Index");
            }
            catch (Exception e)
            {
                return View(model);
            }
        }
    }
}
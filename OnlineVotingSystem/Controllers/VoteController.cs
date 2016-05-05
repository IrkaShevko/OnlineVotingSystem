using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineVotingSystem.Controllers
{
    public class VoteController : Controller
    {
        //
        // GET: /Vote/
        public ActionResult VotingDetails()
        {
            return View();
        }
        public ActionResult MyVotings()
        {
            return View();
        }
        public ActionResult AllVotings()
        {
            return View();
        }
        public ActionResult NewVoting()
        {
            return View();
        }
        public ActionResult Voices()
        {
            return View();
        }
        public ActionResult MostPopular()
        {
            return View();
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamsPractice.Models;

namespace TeamsPractice.Controllers
{
    public class TeamController : Controller
    {
        public static List<Team> lstTeam = new List<Team>();
        // GET: Team
        public ActionResult ShowTeams()
        {
            return View(lstTeam);
        }

       [HttpGet]
        public ActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeam(Team team)
        {
            if (ModelState.IsValid)
            {
                lstTeam.Add(team);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(team);
            }
        }

        [HttpGet]
        public ActionResult EditTeam(string teamCode)
        {
            Team oTeam = lstTeam.Find(x => x.Team_Code == teamCode);
            return View();
        }

        [HttpPost]
        public ActionResult EditTeam(Team team)
        {
            var obj = lstTeam.FirstOrDefault(x => x.Team_Code == team.Team_Code);
            if(obj != null)
            {
                obj.Team_Name = team.Team_Name;
            }
            return View("ShowTeams", lstTeam);
        }
    }
}
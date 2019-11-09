using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamsPractice.Models;

namespace TeamsPractice.Controllers
{
    public class PlayerController : Controller
    {
        public static List<Player> lstPlayer = new List<Player>();
        // GET: Player
        public ActionResult ShowPlayers()
        {
            return View(lstPlayer);
        }

        [HttpGet]
        public ActionResult AddPlayer()
        {
            ViewBag.Teams = TeamController.lstTeam;
            ViewBag.Positions = PositionController.lstPosition;
            return View();
        }

        [HttpPost]
        public ActionResult AddPlayer(Player player)
        {
            if(ModelState.IsValid)
            {
                player.Player_Code = lstPlayer.Count() + 1;
                lstPlayer.Add(player);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(player);
            }
        }
    }
}
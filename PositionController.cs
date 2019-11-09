using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamsPractice.Models;

namespace TeamsPractice.Controllers
{
    public class PositionController : Controller
    {
        public static List<Position> lstPosition = new List<Position>()
        {
            new Position {Position_Code = "G", Position_Desc = "Guard" },
            new Position {Position_Code = "F", Position_Desc = "Forward" },
            new Position {Position_Code = "C", Position_Desc = "Center" }
        };
        // GET: Position
        public ActionResult Index()
        {
            return View();
        }
    }
}
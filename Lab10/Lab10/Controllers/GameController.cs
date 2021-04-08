using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab10.Controllers
{
    public class GameController : Controller
    {
        static int drawnNumber, correctNumber, maxRange;
        static bool isGuessed = false;
        private Random random = new Random();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Set,{number}")]
        public IActionResult Set()
        {
            Int32.TryParse((string)RouteData.Values["number"], out maxRange);
            ViewData["setNumber"] = maxRange;
            return View();
        }

        [Route("Draw")]
        public IActionResult Draw()
        {
            isGuessed = false;
            correctNumber = random.Next(maxRange);
            return View();
        }

        [Route("Guess,{number}")]
        public IActionResult Guess()
        {
            Int32.TryParse((string)RouteData.Values["number"], out drawnNumber);
            if (isGuessed)
            {
                ViewData["result"] = "Już raz odgadłeś liczbę";
                ViewData["color"] = "color:#cd5d7d";
                ViewData["info"] = "Zacznij grę od nowa używając Draw.";
            }
            else
            {
                if (drawnNumber == correctNumber)
                {
                    ViewData["result"] = "Gratulacje!!!";
                    ViewData["color"] = "color:#cd5d7d";
                    ViewData["info"] = "Odgadłeś liczbę.";
                    isGuessed = true;
                }
                else if (drawnNumber > correctNumber)
                {
                    ViewData["result"] = "Spróbuj jeszcze raz.";
                    ViewData["color"] = "color:#6155a6";
                    ViewData["info"] = "Poprawna liczba jest mniejsza.";
                }
                else
                {
                    ViewData["result"] = "Spróbuj jeszcze raz.";
                    ViewData["color"] = "color:#61b15a";
                    ViewData["info"] = "Poprawna liczba jest większa.";
                }
            }

            return View();
        }
        
    }
}

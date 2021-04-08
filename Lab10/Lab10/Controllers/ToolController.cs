using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab10.Controllers
{
    public class ToolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solve()
        {
            int a = 0 , b = 0, c = 0;
            List<string> results = new List<string>();
            string color;
            string equation;
            bool success = true;

            if (!Int32.TryParse((string)RouteData.Values["param1"], out a)){
                success = false;
            }
            else if(!Int32.TryParse((string)RouteData.Values["param2"], out b))
            {
                success = false;
            }
            else if (!Int32.TryParse((string)RouteData.Values["param3"], out c))
            {
                success = false;
            }
            equation = CreatedParams(a, b, c);

            if (success)
            {
                if (a == 0 && b == 0 && c == 0)
                {
                    results.Add("Rownanie tozsamosciowe");
                    color = "color:#0000b3";
                }
                else if (a == 0 && b == 0)
                {
                    results.Add("Równanie sprzeczne");
                    color = "color:#663300";
                }
                else if (a == 0)
                {
                    results.Add("To nie jest funkcja kwadratowa.");
                    color = "color:#006699";
                }
                else
                {
                    (color, results) = CountDelta(a, b, c);
                }
            }
            else
            {
                equation = "Złe parametry";
                color = "color:#0000b3";
            }

            ViewBag.results = results;
            ViewData["color"] = color;
            ViewBag.equation = equation;
            return View();
        }

        private (string, List<string>) CountDelta(int a, int b, int c)
        {
            double delta = (b * b) - (4 * a * c);
            List<string> newList = new List<string>();
            string color;
            if (delta == 0)
            {
                newList.Add("Równanie ma 1 rozwiązanie:");
                newList.Add(((-1) * b / (2 * a)).ToString());
                color = "color:#6155a6";

                return (color, newList);
            }
            else if (delta > 0)
            {
                newList.Add("Rówanie ma dwa rozwiązania:");
                double x1 = Math.Round(((-1) * b - Math.Sqrt(delta)) / (2 * a), 5);
                double x2 = Math.Round(((-1) * b - (-1) * Math.Sqrt(delta)) / (2 * a), 5);
                newList.Add(x1.ToString());
                newList.Add(x2.ToString());

                color = "color:#da9ff9";

                return (color, newList);
            }
            else
            {
                newList.Add("Brak rozwiązania");
                color = "color:#f05454";

                return (color, newList);
            }
        }

        private string CreatedParams(int a, int b, int c)
        {
            string equation = "";

            equation += $"{a}x² ";
            if (b > 0) equation += "+ ";
            equation += $"{b}x ";
            if (c > 0) equation += "+ ";
            equation += $"{c}";

            return equation;
        }
    }
}

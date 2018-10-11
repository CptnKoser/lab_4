using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaffleGenerator;
using System.Web;
using Microsoft.AspNetCore.Html;

namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Waffle()
        {
            var waffle = WaffleEngine.Html(2, true, false);
            return View(new HtmlString(waffle));
        }
    }
}
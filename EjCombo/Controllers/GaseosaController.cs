using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjCombo.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EjCombo.Controllers
{
    public class GaseosaController : Controller
    {
        private readonly IGaseosaService gaseosaService;

        public GaseosaController(IGaseosaService gaseosaService)
        {
            this.gaseosaService = gaseosaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetGaseosa()
        {
            var gaseosas = gaseosaService.TraerTodasLasGaseosas();
            return Json(gaseosas);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.WebApi.Controllers
{
    public class BaseController : Controller
    {
        public void SetTitle(string title)
        {
            ViewBag.Title = title;
        }
        public void SetAlert(string message, bool danger = false)
        {
            if (danger)
            {
                TempData.Add("danger", "true");
            }
            TempData.Add("message", message);
        }
    }
}
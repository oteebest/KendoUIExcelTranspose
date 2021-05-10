using KendoUIGridProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KendoUIGridProject.Controllers
{
    public class ImportController : Controller
    {
        // GET: Import
        public ActionResult Index()
        {
            return View("ImportFinancials");
        }

        [HttpPost]
        public async Task<ActionResult> Financials(List<Financials> model)
        {

            return Json(new { success = true, message = "Saved successfully" });

        }
    }
}
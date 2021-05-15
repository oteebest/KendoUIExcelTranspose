using KendoUIGridProject.Models;
using KendoUIGridProject.Util;
using System;
using System.Collections.Generic;
using System.IO;
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
            return View("ImportFinancials2");
        }


        [HttpPost]
        public async Task<ActionResult> Data()
        {
            Request.InputStream.Seek(0, SeekOrigin.Begin);
            string jsonData = new StreamReader(Request.InputStream).ReadToEnd();


            return Json(new { success = true, message = "Saved successfully" });

        }


        [HttpPost]
        public async Task<ActionResult> Financials(List<Financials> model)
        {

            return Json(new { success = true, message = "Saved successfully" });

        }



        [HttpPost]
        public async Task<ActionResult> SaveFinancials(List<ExcelRequestModel> items )
        {
            if(items == null)
            {
                return Json(new { success = false, message = "You do not have entries to save" });

            }

            string[] lables = new[] { "Year", "Sales", "Cost", "Profit" };

            items = items.Where(u => lables.Contains(u.Label)).ToList();

            if (items.Count != 4)
            {
                return Json(new { success = false, message = "You are missing either Year, Sales, Cost or Profit row. Review your entries" });
            }

            var financials  = items.GetFinancials();

            return Json(new { success = true, message = "Saved successfully" });

        }
    }
}
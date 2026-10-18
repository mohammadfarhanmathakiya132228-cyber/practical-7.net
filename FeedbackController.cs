using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using prct7.Models;

namespace prct7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList =
            new List<Feedback>();

        public ActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);

                return RedirectToAction("Index");
            }

            return View(feedback);
        }

        public ActionResult Index()
        {
            return View(feedbackList.ToList());
        }
    }
}
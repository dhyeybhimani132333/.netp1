using System.Web.Mvc;
using P7.Models;

namespace P7.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        // POST: Feedback/Submit
        [HttpPost]
        public ActionResult Submit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Feedback submitted successfully!";
                return View("Index", feedback);
            }

            return View("Index", feedback);
        }
    }
}

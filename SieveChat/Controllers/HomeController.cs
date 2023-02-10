using SieveChat.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SieveChat.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db;
        public HomeController()
        {
            db = new AppDbContext();
        }

        public ActionResult Index()
        {
            var _data = db.ChatMsg.ToList().OrderBy(x=>x.CREATE_DATE);
            return View(_data);
        }
        public ActionResult WriteMsg()
        {
            var obj = new ChatMsg();
            obj.MSG_ID = Guid.NewGuid().ToString();

            return View(obj);
        }

        [HttpPost]
        public ActionResult WriteMsg(ChatMsg obj)
        {
            try
            {
                db.ChatMsg.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View(obj);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
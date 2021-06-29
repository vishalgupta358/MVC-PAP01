using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository.Interface;
using WebApplication2.Repository;
using WebApplication2.Repository.Class;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private IUser _user = Factory.GetUserInstance();
        public ActionResult CreateUser()
        {           
            return View(_user.GetUsers());
        }

        [HttpPost]
        public ActionResult CreateUser(UserModel model)
        {
            if (ModelState.IsValid)
            {
                _user.CreateUser(model);
            }
            return RedirectToAction("CreateUser");
        }

        [HttpGet]
        public PartialViewResult Edit(int userId)
        {            
            return PartialView("EditUser", _user.GetUser(userId));
        }
        [HttpPost]
        public ActionResult Edit(UserModel editModel)
        {
            _user.UpdateUser(editModel);
            return RedirectToAction("CreateUser");
        }

        public PartialViewResult AddUser()
        {
            return PartialView("AddUser");
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
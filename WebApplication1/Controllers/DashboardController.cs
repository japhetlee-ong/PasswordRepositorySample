using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            using(PassRepoDbEntities entities = new PassRepoDbEntities())
            {
                if (Session["user_id"] == null)
                {
                    return RedirectToAction("Index", "Login");

                }
                var userId = (Int32) Session["user_id"];
                var passwordData = entities.TBL_USER_PASSWORDS.Where(x=> x.USER_ID== userId).ToList();

                var passwordList = new List<PasswordModel>();

                foreach(var pass in passwordData)
                {
                    passwordList.Add(new PasswordModel
                    {
                        ID = pass.ID,
                        SITE_NAME = pass.SITE_NAME,
                        SITE_PASSWORD = pass.SITE_PASSWORD,
                    });
                }

                var dashboardModel = new DashboardModel
                {
                    PasswordList = passwordList,
                    PasswordModel = new PasswordModel()
                };

                return View(dashboardModel);

            }
        }

        //[HttpPost]
        //public ActionResult Index(PasswordModel)
        //{

        //}

    }
}
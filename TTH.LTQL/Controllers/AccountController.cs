using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TTH.LTQL.Models;

namespace TTH.LTQL.Controllers
{
     [Authorize(Roles= "Huong1")]
    public class AccountController : Controller
    {

        LTQLDbContext db = new LTQLDbContext();
        [AllowAnonymous]
        // GET: Account
        //Action Login(HttpGet), mặc định là get
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        //nhận dữ liệu từ client gửi lên
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountModel acc, string returnUrl)
        {
            //var db = new LTQLDbContext();
            
            // Nếu vượt qua được validation ở accounmodel
            if (ModelState.IsValid)
            {
                //kiểm tra thông tin đăng nhập
                var model = db.AccountModels.Where(t => t.Username == acc.Username && t.Password == acc.Password).ToList().Count();
                if (model==1)
                {
                    //set cookie
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(acc);
        }
        //hàm đăng xuất khỏi chương trình
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //Kiểm tra xem returUrl có thuộc hệ thống hay không
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
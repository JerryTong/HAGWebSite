using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HAGWebSite.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index(string memberId)
        {
            return View();
        }
    }
}
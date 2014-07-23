using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactList.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        public ContentResult Secret()
        {
            return Content("this is a secret");
        }

        public ContentResult Overt()
        {
            return Content("this is not a secret");
        }
    }
}
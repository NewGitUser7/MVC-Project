using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ME.Site.Controllers
{
    public class PositionController : Controller
    {
        #region Constructor
        
        public PositionController()
        {

        }

        #endregion
        public ActionResult CreatePosition()
        {
            ViewData["message"] = "New functionality has to be developed";
            return View();
        }
    }
}
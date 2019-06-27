using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebHook.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
     

        [HttpPost]
        public JsonResult EchoWebhook(ModelMessage inMsg)
        { 
            ModelMessage outMsg = new ModelMessage();
            outMsg.from = inMsg.from;
            outMsg.msg = "Echo: " + inMsg.msg;
            return Json(outMsg, JsonRequestBehavior.AllowGet);
        }

    }
    public class ModelMessage
    {
        public string from { get; set; }
        public string msg { get; set; }
    }

}
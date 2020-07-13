using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Extension
{
    public class Protection : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var comp = filterContext.HttpContext.Session["compId"];
            if (comp == null)
                filterContext.Result = new RedirectResult(string.Format("/Home/Companies", filterContext.HttpContext.Request.Url.AbsolutePath));
        }
    }

    public class AntiProtection : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var comp = filterContext.HttpContext.Session["compId"];
            if (comp != null)
                filterContext.Result = new RedirectResult(string.Format("/Home/List", filterContext.HttpContext.Request.Url.AbsolutePath));
        }
    }
}
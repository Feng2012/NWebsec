﻿using System.Web.Mvc;
using System.Web.Security;
using DemoSiteMvc4.CustomAttribute;
using NWebsec.Mvc.HttpHeaders;
using NWebsec.Mvc.HttpHeaders.Csp;

namespace DemoSiteMvc4.Controllers
{
    [AllowMultiple("Controller")]
    //[Csp]
        [CspSandbox(AllowPointerLock = true)]
    
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //[CspScriptSrc(UnsafeInline = Source.Enable, CustomSources = "www.nwebsec.com")]
        //[CspStyleSrc(UnsafeInline = Source.Enable, CustomSources = "www.nwebsec.com")]
        //[CspFrameAncestors(Self = Source.Enable)]
        //[CspBaseUri(CustomSources = "mvcbase.klings.org")]
        //[CspChildSrc(CustomSources = "child.klings.org")]
        //[CspFormAction(CustomSources = "forms.klings.org")]
        
        [CspPluginTypes(MediaTypes = "application/klings", InheritMediaSources = true)]
        [CspReportOnly]
        public ActionResult Index()
        {
            //return new EmptyResult();
            return View();
        }

        [AllowMultiple("Action")]
        [XFrameOptions(Policy = XFrameOptionsPolicy.Disabled)]
        [CspSandbox(AllowForms = true, AllowPointerLock = false, AllowPopups = true)]
        [Csp]
        public ActionResult Other()
        {
            return View("Index");

            var s = $"hheyhey" +
            "duddelidei";
        }

        [Csp(Enabled = false)]
        public ActionResult Referrer()
        {
            Response.AppendHeader("Content-Security-Policy","referrer none");
            return View();
        }

        public ActionResult Authenticated(string user ="klings")
        {
            if (!User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SetAuthCookie(user,false);
            }
            Session["Hey"] = "whatever";
            return View("Index");
        }

        [RequireHttps]
        public ActionResult RequireHttps()
        {
            return Redirect("https://localhost:8443/DemoSiteMvc4");
        }

        [CspFrameAncestors(None = true)]
        public ActionResult Framed()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MuhasebeWeb.Controllers;

namespace MuhasebeWeb.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MuhasebeWebControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

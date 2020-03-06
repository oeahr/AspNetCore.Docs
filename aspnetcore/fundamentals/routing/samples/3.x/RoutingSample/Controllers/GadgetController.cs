﻿using Microsoft.AspNetCore.Mvc;


namespace RoutingSample.Controllers
{
    #region snippet
    public class GadgetController : Controller
    {
        public IActionResult Index()
        {
            var url = Url.Action("Edit", new { id = 17, });
            return Content(url);
        }
        #endregion

        public IActionResult Edit(int id) =>
            ControllerContext.MyDisplayRouteInfo(id);
    }
}
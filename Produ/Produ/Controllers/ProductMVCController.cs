using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Produ.Models;
using System.Net.Http;

namespace Produ.Controllers
{
    public class ProductMVCController : Controller
    {
        // GET: ProductMVC
        public ActionResult Index()
        {
            IEnumerable<productmodel> productlist;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("ProductNews").Result;

            productlist = response.Content.ReadAsAsync<IEnumerable<productmodel>>().Result;


            return View(productlist);
        }

        public ActionResult Details(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync($"ProductNews/{id}").Result;
            return View(response.Content.ReadAsAsync<productmodel>().Result);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JuniorMVC3Test.Models;

namespace JuniorMVC3Test.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display(ProductInputModel productInputModel)
        {
            var productModel = new ProductOutputModel();
            productModel.Id = 1;
            productModel.Name = "Docka";

            return View(productModel);
        }

        public ActionResult ListAll()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(ProductInputModel inputModel)
        {
            var productModel = new ProductOutputModel();
            productModel.Id = 1;
            productModel.Name = inputModel.Name;
            return View(productModel);
        }

    }
}

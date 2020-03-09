using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDD.Models;

namespace TDD.Controllers
{


    //En Test Driven Development primero creaslas pruebas que hacen referencia a metodos vacios de un controlador y eso provoca que fallen las pruebas al ejecutarlas
    //El segundo paso es implementar codigo en los metodos con codigo simple o incluso quemado solo para que pasen la prueba
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View("Index");
        }

        public PartialViewResult _CategoryList()
        {
            List<Models.Category> Categories = new List<Models.Category>();
            return PartialView("_CategoryList",Categories);
         }

        public ActionResult GetImage(int id)
        {
            byte[] Image = new byte[0];
            return File(Image, "image/jpeg");
        }

        public ViewResult Display(int id)
        {
            var Category = new Models.Category();
            return View(Category);
           
        }
    }
}
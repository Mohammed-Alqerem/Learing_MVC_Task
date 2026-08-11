using CRUDTask.Data;
using CRUDTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDTask.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        public IActionResult Edit(int Id)
        {
            var product = context.Products.Find(Id);
            
            return View(product);
        }
        public IActionResult Update(Product request)
        {
            var product = context.Products.Update(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            var deleteProduct = context.Products.Remove(context.Products.Find(Id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View(new Product());
        }
        public IActionResult Add (Product request)
        {
            if (ModelState.IsValid)
            {
                 var createProduct =  context.Products.Add(request);
                 context.SaveChanges();
                 return RedirectToAction("Index");

            }
            return View("create",request);
        }
    }
}

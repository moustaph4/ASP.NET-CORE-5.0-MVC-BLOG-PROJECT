using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProjesi.Controllers
{
    public class Category : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {

            var values = cm.GetAllCategories(); 
            return View(values);
        }
    }
}

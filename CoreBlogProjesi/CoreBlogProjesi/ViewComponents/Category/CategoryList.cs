using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProjesi.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var values = cm.GetAllCategories();
			return View(values);
		}
	}
}

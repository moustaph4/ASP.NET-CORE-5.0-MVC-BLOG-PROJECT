using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProjesi.ViewComponents.Blog
{
	public class WriterLastBlogs :ViewComponent
	{

		BlogManager bm = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListByWriter(4);
			return View(values);

		}

	}
}

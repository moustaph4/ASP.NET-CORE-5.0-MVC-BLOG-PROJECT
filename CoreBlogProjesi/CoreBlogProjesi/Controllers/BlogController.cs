using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreBlogProjesi.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{

			var values = bm.GetBlogListWithCategory();

			return View(values);
		}

		public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;
			var values = bm.GetBlogById(id);
			return View(values);
		}
	}
}

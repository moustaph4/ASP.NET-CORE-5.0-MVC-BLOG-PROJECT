using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProjesi.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index(int id)
		{
			var values = cm.GetAllComments(id);	

			return View();
		}
	}
}

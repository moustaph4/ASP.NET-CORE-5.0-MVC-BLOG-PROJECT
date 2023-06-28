using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProjesi.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var values = cm.GetAllComments(id);

			return View(values);
		}

	}
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{

		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentInsert(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetAllComments(int id)
		{
			return _commentDal.GetAll(x => x.BlogId == id);
		}
	}
}

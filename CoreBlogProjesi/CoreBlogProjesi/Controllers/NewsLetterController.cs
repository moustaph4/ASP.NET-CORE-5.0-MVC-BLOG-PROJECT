﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogProjesi.Controllers
{
	public class NewsLetterController : Controller
	{
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter p)
		{
			return PartialView();
		}
	}
}

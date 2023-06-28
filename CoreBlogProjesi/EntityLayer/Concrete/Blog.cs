using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public string BlogThumbnailImage { get; set; }

        public string BlogImage { get; set; }

        public DateTime BlogCreateDate { get; set; }

        public bool BlogStatus { get; set; }

        // Kategori tablosundaki CategoryId ile Blog tablosundaki CategoryId yi birbirine bağlayacağız
        public int CategoryId { get; set; }

        public Category Category { get; set; }

		// -----------------------------------

		public int WriterId { get; set; }

		public Writer Writer { get; set; }


		// Bir bloğa birden fazla yorum yapılabilir. Birden çoğa ilişki.

		public List<Comment> Comments { get; set; }

        // -----------------------------------

    }
}

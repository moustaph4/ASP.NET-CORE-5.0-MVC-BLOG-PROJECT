using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {

        // Erişim belirleyici - Tür - İsim - {get set}

        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }    

        public string CategoryDescription { get; set; } 

        public bool CategoryStatus { get; set; }

        // Kategori tablosundaki CategoryId ile Blog tablosundaki CategoryId yi birbirine bağlayacağız
        public List<Blog> Blogs { get; set; }

        // -----------------------------------
    }
}

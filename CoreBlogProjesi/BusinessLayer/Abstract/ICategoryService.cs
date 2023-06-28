using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{

    // Business katmanında amacımımız validasyon yani doğrulama işlemi yapmaktır.
    // Örneğin Blog ismi 10 karakterden fazla olamaz gibi sınırlar koymaktır.

    // Abstract klasörü içinde oluşturduğumuz interfacelerde ( Ekle - Sil - Güncelle - Listele - Id değerine göre getir )
    // metotlarımızı oluşturacağız daha sonra bu metotlarımızın içini,
    // Concrete klasöründe oluşturacağımız ilgili Manager classlarında dolduracağız.

    public interface ICategoryService
    {
        void CategoryInsert(Category category);

        void CategoryUpdate(Category category);

        void CategoryDelete(Category category);

        List<Category> GetAllCategories();

        Category GetById(int id);
    }
}

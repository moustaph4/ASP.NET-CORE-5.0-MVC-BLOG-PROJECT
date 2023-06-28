using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{

    // IGeneriDal da oluşturduğumuz metotlarımızın içindeki işlemleri burada tanımlayacağız.

    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T entity)
        {
            // using kullanınca oluşturduğumuz islem değişkeni kullanıldıktan sonra silinebiliyor.
            // Bu yüzden using kullanarak değişken oluşturduk.

            using var islem = new Context();
            islem.Add(entity);
            islem.SaveChanges();
        }

        public void Update(T entity)
        {
            using var islem = new Context();
            islem.Update(entity);
            islem.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var islem = new Context();
            islem.Remove(entity);
            islem.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var islem = new Context();

            // Örnek olarak Blog clasını burda çağıramadığımız için Entiti olan T yi Set komutu içinde çağırdık.
            // Örneğin Set<T>() burada islem.Blog.ToList(); gibi çalışıcak.

            return islem.Set<T>().ToList(); 

        }

        public T GetById(int id)
        {
            using var islem = new Context();
            return islem.Set<T>().Find(id);
        }

		public List<T> GetAll(Expression<Func<T, bool>> filter)
		{
			using var islem = new Context();
            return islem.Set<T>().Where(filter).ToList();
		}
	}
}

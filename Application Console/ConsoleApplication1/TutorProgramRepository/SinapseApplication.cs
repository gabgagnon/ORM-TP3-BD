using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SinapseApplication
    {
        public interface IEntityRepository<T> where T : Entity
        {
            public IQueryable<T> GetAll();
            public T GetById(int id);
            public void DeleteAll();
            public void Delete(T entity);
            public void Add(T entity);
            public void Update(T entity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Model;

namespace ConsoleApplication1
{
        public interface IEntityRepository<T> where T : Entity
        {
             IQueryable<T> GetAll();
             T GetById(int id);
             void DeleteAll();
             void Delete(T entity);
             void Add(T entity);
             void Update(T entity);
        }
}

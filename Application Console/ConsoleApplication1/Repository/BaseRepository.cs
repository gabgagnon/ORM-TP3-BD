using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Context;
using ConsoleApplication1.Model;
using System.Data.Entity;

namespace ConsoleApplication1.Context
{
    public class BaseRepository<T> : IEntityRepository<T> where T : Entity
    {   
        protected readonly ProjetContext sinapseContext;

        public BaseRepository(ProjetContext sinapseContext)
        {
            this.sinapseContext = sinapseContext;
        }
    
        public IQueryable<T> GetAll()
        {
            return sinapseContext.Set<T>().AsQueryable();
        }
        public T GetById(int id)
        {
            return sinapseContext.Set<T>().Find(id);
        }
        public void DeleteAll()
        {
            sinapseContext.Set<T>().RemoveRange(GetAll());
        }
        public void Delete(T entity)
        {
            sinapseContext.Set<T>().Remove(entity);
            sinapseContext.SaveChanges();
        }
        public void Insert(T entity)
        {
            sinapseContext.Set<T>().Add(entity);
            sinapseContext.SaveChanges();
        }
        public void Update(T entity)
        {
            sinapseContext.Set<T>().Attach(entity);
            sinapseContext.Entry(entity).State = EntityState.Modified;
            sinapseContext.SaveChanges();
        }
    }
}

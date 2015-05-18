using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Context;
using ConsoleApplication1.Model;

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
            return null;
        }
        public void DeleteAll()
        {
        }
        public void Delete(T entity)
        {
        }
        public void Add(T entity)
        {
            //SinapseContext.
        }
        public void Update(T entity)
        { 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Repository
{
    class SinapseRepositorySinapseRepository<T> : IEntityRepository<T> where T : Entity
    {

    protected readonly ProjectContext context;
    public SinapseRepository (ProjectContext sinapseContext)
    {
    this.context = sinapseContext;
    //Database.setInitializer<SipnapseContext>(initializer);
        // initializer.initializeDatabase(context);
    }
    public IQueryable<T> GetAll()
    {
     // return SinapseContext.Set<T>().AsQueryable();
    }
    public T GetById(int id)
    {}
    public void DeleteAll()
    {}
    public void Delete(T entity)
    {}
    public void Add(T entity)
    {
    //SinapseContext.
    }
    public void Update(T entity)
    {}
    }
}

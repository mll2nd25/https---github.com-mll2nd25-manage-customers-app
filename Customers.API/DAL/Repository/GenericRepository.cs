
using Customers.API.DAL.Interaces;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace Customers.API.DAL.Repository.Interface
{
    public abstract class GenericReporitory<T> : IGenericRepsoitory<T> where T : EntityBase
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;

        private void Save()
        {
            _context.SaveChanges();
        }

        public GenericReporitory(DataContext context)
        {
            this._context = context;
            _dbSet = context.Set<T>();
        }

        public virtual IEnumerable<T> Get()
        {
            return _dbSet;
        }

        public virtual IEnumerable<T> FilterBy(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(T entity)
        {
            _context.Add(entity);

            Save();
        }
        
        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            Save();
        }

        public virtual void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
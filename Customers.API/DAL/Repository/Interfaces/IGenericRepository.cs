
namespace Customers.API.DAL.Interaces
{
    public interface IGenericRepsoitory<T> where T: EntityBase
    {
        IEnumerable<T> Get();
        IEnumerable<T> FilterBy(Func<T,bool> predicate);

        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
    }  
}
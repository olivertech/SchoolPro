namespace SchoolPro.Core.Interfaces.Base
{
    public interface IRepositoryBase<T> 
        where T : DefaultBase
    {
        Task<IEnumerable<T>?> GetAll();
        Task<T?> GetById(Guid? id);
        Task<IEnumerable<T>?> GetList(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T?>> GetPagedList(int pageSize, int pageNumber);
        Task<IEnumerable<T?>> GetPagedList(Expression<Func<T, bool>> predicate, int pageSize, int pageNumber);
        Task<int> Count();
        Task<T?> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(Guid? id, bool isLogicalDelete);
    }
}

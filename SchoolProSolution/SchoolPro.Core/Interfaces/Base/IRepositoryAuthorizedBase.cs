namespace SchoolPro.Core.Interfaces.Base
{
    public interface IRepositoryAuthorizedBase<T> 
        where T : AuthorizedBase
    {
        Task<IEnumerable<T>?> GetAll(string clientSchoolKey);
        Task<T?> GetById(Guid? id, string clientSchoolKey);
        Task<IEnumerable<T>?> GetList(Expression<Func<T, bool>> predicate, string clientSchoolKey);
        Task<IEnumerable<T?>> GetPagedList(int pageSize, int pageNumber, string clientSchoolKey);
        Task<IEnumerable<T?>> GetPagedList(Expression<Func<T, bool>> predicate, int pageSize, int pageNumber, string clientSchoolKey);
        Task<int> Count(string clientSchoolKey);
        Task<T?> Insert(T entity, string clientSchoolKey);
        Task<bool> Update(T entity, string clientSchoolKey);
        Task<bool> Delete(Guid? id, bool isLogicalDelete, string clientSchoolKey);
    }
}

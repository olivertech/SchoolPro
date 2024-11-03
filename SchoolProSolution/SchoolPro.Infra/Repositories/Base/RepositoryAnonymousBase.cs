namespace SchoolPro.Infra.Repositories.Base
{
    public class RepositoryAnonymousBase<T> : IRepositoryAnonymousBase<T>
        where T : AnonymousBase
    {
        protected readonly SchoolProDbContext? _context;
        protected readonly DbSet<T>? _dbSet;

        public RepositoryAnonymousBase([NotNull] SchoolProDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>?> GetAll()
        {
            try
            {
                var list = await _dbSet!.AsNoTracking().ToListAsync();

                return list ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a lista.", ex);
            }
        }

        public async Task<T?> GetById(Guid? id)
        {
            try
            {
                var entity = await _dbSet!.Where(x => x.Id == id).FirstOrDefaultAsync();

                if (entity == null)
                    throw new InvalidOperationException("Registro não encontrado!");

                return entity!;
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a id informado.", ex);
            }
        }

        public async Task<IEnumerable<T>?> GetList(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var list = await _dbSet!.AsNoTracking().Where(predicate).ToListAsync();

                return list ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a lista.", ex);
            }
        }

        public async Task<IEnumerable<T?>> GetPagedList(int pageSize, int pageNumber)
        {
            try
            {
                var list = await _dbSet!
                                .AsNoTracking()
                                .Skip((pageNumber - 1) * pageSize)
                                .Take(pageSize)
                                .ToListAsync();

                return list ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a lista paginada.", ex);
            }
        }

        public async Task<IEnumerable<T?>> GetPagedList(Expression<Func<T, bool>> predicate, int pageSize, int pageNumber)
        {
            try
            {
                var list = await _dbSet!
                                .AsNoTracking()
                                .Where(predicate)
                                .Skip((pageNumber - 1) * pageSize)
                                .Take(pageSize)
                                .ToListAsync();

                return list ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a lista paginada.", ex);
            }
        }

        public async Task<int> Count()
        {
            try
            {
                var list = await _dbSet!.ToListAsync();

                return list.Count;
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar o total.", ex);
            }
        }

        public async Task<T?> Insert(T entity)
        {
            try
            {
                if (entity is null)
                    throw new ArgumentNullException(nameof(entity));

                await _dbSet!.AddAsync(entity);
                await _context!.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível inserir a entidade.", ex);
            }
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                if (entity is null)
                    throw new ArgumentNullException(nameof(entity));

                var item = await _dbSet!.FindAsync(entity.Id);

                if (item is not null)
                {
                    _dbSet.Update(entity);
                }

                return await _context!.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível atualizar a entidade.", ex);
            }
        }

        public async Task<bool> Delete(Guid? id, bool isLogicalDelete)
        {
            try
            {
                var entity = await GetById(id);

                if (entity is null)
                    throw new InvalidOperationException("Registro não encontrado!");

                if (isLogicalDelete)
                {
                    entity.IsActive = false;
                    await Update(entity);
                }
                else
                {
                    _dbSet!.Remove(entity);
                }

                return await _context!.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível remover a entidade.", ex);
            }
        }
    }
}

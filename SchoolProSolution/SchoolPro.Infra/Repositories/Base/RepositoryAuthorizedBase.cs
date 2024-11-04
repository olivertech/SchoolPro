namespace SchoolPro.Infra.Repositories.Base
{
    public class RepositoryAuthorizedBase<T> : IRepositoryAuthorizedBase<T>
        where T : AuthorizedBase
    {
        protected readonly SchoolProDbContext? _context;
        protected readonly DbSet<T>? _dbSet;

        public RepositoryAuthorizedBase([NotNull] SchoolProDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>?> GetAll(string clientSchoolKey)
        {
            try
            {
                var list = await _dbSet!.AsNoTracking()
                                        .Where(x => x.ClientSchoolKey == clientSchoolKey)
                                        .ToListAsync();

                return list ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a lista.", ex);
            }
        }

        public async Task<T?> GetById(Guid? id, string clientSchoolKey)
        {
            try
            {
                var entity = await _dbSet!.Where(x => x.Id == id && x.ClientSchoolKey == clientSchoolKey).FirstOrDefaultAsync();

                if (entity == null)
                    throw new InvalidOperationException("Registro não encontrado!");

                return entity!;
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a id informado.", ex);
            }
        }

        public async Task<IEnumerable<T>?> GetList(Expression<Func<T, bool>> predicate, string clientSchoolKey)
        {
            try
            {
                var list = await _dbSet!.AsNoTracking()
                                        .Where(predicate)
                                        .Where(x => x.ClientSchoolKey == clientSchoolKey).ToListAsync();

                return list ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar a lista.", ex);
            }
        }

        public async Task<IEnumerable<T?>> GetPagedList(int pageSize, int pageNumber, string clientSchoolKey)
        {
            try
            {
                var list = await _dbSet!
                                .AsNoTracking()
                                .Where(x => x.ClientSchoolKey == clientSchoolKey) 
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

        public async Task<IEnumerable<T?>> GetPagedList(Expression<Func<T, bool>> predicate, int pageSize, int pageNumber, string clientSchoolKey)
        {
            try
            {
                var list = await _dbSet!
                                .AsNoTracking()
                                .Where(predicate)
                                .Where(x => x.ClientSchoolKey == clientSchoolKey)
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

        public async Task<int> Count(string clientSchoolKey)
        {
            try
            {
                var list = await _dbSet!.Where(x => x.ClientSchoolKey == clientSchoolKey).ToListAsync();

                return list.Count;
            }
            catch (Exception ex)
            {
                throw new Exception("RepositoryError - Não foi possível recuperar o total.", ex);
            }
        }

        public async Task<T?> Insert(T entity, string clientSchoolKey)
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

        public async Task<bool> Update(T entity, string clientSchoolKey)
        {
            try
            {
                if (entity is null)
                    throw new ArgumentNullException(nameof(entity));

                var item = await _dbSet!.FindAsync(entity.Id);

                if (item is not null && item.ClientSchoolKey == clientSchoolKey)
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

        public async Task<bool> Delete(Guid? id, bool isLogicalDelete, string clientSchoolKey)
        {
            try
            {
                var entity = await GetById(id, clientSchoolKey);

                if (entity is null)
                    throw new InvalidOperationException("Registro não encontrado!");

                if (isLogicalDelete)
                {
                    entity.IsActive = false;
                    await Update(entity, clientSchoolKey);
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

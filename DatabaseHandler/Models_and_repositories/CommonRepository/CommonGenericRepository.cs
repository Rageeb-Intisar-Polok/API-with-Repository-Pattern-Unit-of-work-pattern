using DatabaseHandler.Context;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.CommonRepository
{
    public class CommonGenericRepository<T> : ICommonGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public CommonGenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            var a = await _context.Set<T>().AddAsync(entity);
        }

        public async Task<string> AddSome(IEnumerable<T> entities)
        {
            IEnumerable<T> _entities = entities;
            string to_return = "action undefined";
            try
            {
                foreach(var entity in _entities)
                {
                    _context.Set<T>().AddAsync(entity);
                }
                to_return = "list added successfully";
            }
            catch(Exception ex)
            {
                to_return = ex.Message;
            }
            return to_return;
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            //  return _context.Set<T>().ToList();
            var a = await _context.Set<T>().ToListAsync<T>();
            return a;
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}

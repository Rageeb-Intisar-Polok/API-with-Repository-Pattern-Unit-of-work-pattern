using AdminDBHandler.Models.User.User_Types;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.CommonRepository
{
    public interface ICommonGenericRepository<T> where T : class
    {
        public Task Add(T entity);
        public Task<string> AddSome(IEnumerable<T> entities);

        public Task Delete(T entity);

        public Task<IEnumerable<T>> GetAll();

        public Task Update(T entity);


    }
}

using DatabaseHandler.Models_and_repositories.CommonRepository;

namespace DatabaseHandler.Models_and_repositories.Role.RoleRepository
{
    public interface IRoleRepository : ICommonGenericRepository<Role>
    {
        public Task<Role> getByName(string name);
        public Task<Role> getRoleId(int id);
    }
}

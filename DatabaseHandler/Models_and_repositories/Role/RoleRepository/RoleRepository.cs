using AdminDBHandler.Models.Dept_Level_Term;
using DatabaseHandler.Context;
using DatabaseHandler.Models_and_repositories.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.Role.RoleRepository
{
    public class RoleRepository : CommonGenericRepository<Role>, IRoleRepository
    {
        ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Role> getByName(string name)
        {
            Role role = await _context.roles.Where(x => x.RoleName == name).FirstOrDefaultAsync();
            return role;
        }
        public async Task<Role> getRoleId(int id)
        {
            Role role = await _context.roles.FindAsync(id);
            return role;
           // return _context.roles.Find(id);
        }
    }
}

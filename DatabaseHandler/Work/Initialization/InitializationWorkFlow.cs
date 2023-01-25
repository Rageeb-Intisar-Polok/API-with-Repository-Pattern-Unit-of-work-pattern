using AdminDBHandler.Models.Dept_Level_Term;
using DatabaseHandler.Context;
using DatabaseHandler.Models_and_repositories.CommonRepository;
using DatabaseHandler.Models_and_repositories.Role.RoleRepository;

namespace DatabaseHandler.Work.Initialization
{
    public class InitializationWorkFlow : IInitializationWorkFlow ,IDisposable
    {
        public ApplicationDbContext _context;
        public ICommonGenericRepository<Department> _departmentHandlingRepository { get; private set; }
        public ICommonGenericRepository<Level_Term> _levelTermRepository { get; private set; }
        public IRoleRepository _roleRepository { get; private set; }
        public InitializationWorkFlow(ApplicationDbContext context, ICommonGenericRepository<Department>
            departmentHandlingRepository, ICommonGenericRepository<Level_Term> levelTermRepository,
            IRoleRepository roleRepository)
        {
            _context = context;
            _departmentHandlingRepository = departmentHandlingRepository;
            _levelTermRepository = levelTermRepository;
            _roleRepository = roleRepository;
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

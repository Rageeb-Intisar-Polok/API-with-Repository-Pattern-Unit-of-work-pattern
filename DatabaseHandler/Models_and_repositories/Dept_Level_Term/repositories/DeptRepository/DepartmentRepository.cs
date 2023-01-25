using AdminDBHandler.Models.Dept_Level_Term;
using DatabaseHandler.Context;
using DatabaseHandler.Models_and_repositories.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.Dept_Level_Term.repositories.DeptRepository
{
    public class DepartmentRepository : CommonGenericRepository<Department> , IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Department> getDepartmentById(int id)
        {
            Department _dept;
            _dept = await _context.departments.FindAsync(id);
            return _dept;
        }
        public async Task<Department> getDeptByName(string name)
        {
            Department dept = await _context.departments.Where(x => x.DeptName == name).FirstOrDefaultAsync();
            return dept;
        }
    }
}

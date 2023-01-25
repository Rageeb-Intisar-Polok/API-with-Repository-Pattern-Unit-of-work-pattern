using AdminDBHandler.Models.Dept_Level_Term;
using DatabaseHandler.Models_and_repositories.CommonRepository;

namespace DatabaseHandler.Models_and_repositories.Dept_Level_Term.repositories.DeptRepository
{
    public interface IDepartmentRepository : ICommonGenericRepository<Department>
    {
        public Task<Department> getDepartmentById(int id);
        public Task<Department> getDeptByName(string name);
    }
}

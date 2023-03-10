using AdminDBHandler.Models.User.User_Types;
using DatabaseHandler.Context;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.User.User_Types.UserTypeRepositories.Student_Repository
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Students> GetStudentByUniqueId(int individualId)
        {
            Students t = await _context.students.Where(x => x.IndividualId == individualId).FirstOrDefaultAsync();
            return t;
        }
    }
}

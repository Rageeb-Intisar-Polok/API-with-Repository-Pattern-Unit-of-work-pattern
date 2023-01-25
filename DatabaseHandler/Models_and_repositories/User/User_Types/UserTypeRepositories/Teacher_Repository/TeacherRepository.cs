using AdminDBHandler.Models.User.User_Types;
using DatabaseHandler.Context;
using DatabaseHandler.Models_and_repositories.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.User.User_Types.UserTypeRepositories.Teacher_Repository
{
    public class TeacherRepository : CommonGenericRepository<Teachers>, ITeacherRepository
    {
        private ApplicationDbContext _context;
        public TeacherRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Teachers> GetTeacherByUniqueId(int individualId)
        {
            Teachers t = await _context.teachers.Where(x => x.IndividualId == individualId).FirstOrDefaultAsync();
            return t;
        }

    }
}

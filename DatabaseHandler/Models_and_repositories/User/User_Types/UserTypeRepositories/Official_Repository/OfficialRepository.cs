using AdminDBHandler.Models.User.User_Types;
using DatabaseHandler.Context;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.User.User_Types.UserTypeRepositories.Official_Repository
{
    public class OfficialRepository : IOfficialRepository
    {
        private ApplicationDbContext _context;
        public OfficialRepository(ApplicationDbContext context)
        {
            _context= context;
        }
        public async Task<Officials> GetOfficialByUniqueId(int individualId)
        {
            Officials t = await _context.officials.Where(x => x.IndividualId == individualId).FirstOrDefaultAsync();
            return t;
        }
    }
}

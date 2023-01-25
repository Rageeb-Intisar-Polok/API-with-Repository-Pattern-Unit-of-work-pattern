using AdminDBHandler.Models.Dept_Level_Term;
using DatabaseHandler.Context;
using DatabaseHandler.Models_and_repositories.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Models_and_repositories.Dept_Level_Term.repositories.LevelTermRepository
{
    public class LevelTermRepository : CommonGenericRepository<Level_Term>, ILevelTermRepository
    {
        ApplicationDbContext _context;
        public LevelTermRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Level_Term> getLevelTermEntity(int level, string term)
        {
            Level_Term lt = await _context.levelTerm.Where(a => (a.Level == level && a.Term == term)).FirstOrDefaultAsync();
            return lt;
        }
        public async Task<Level_Term> getLevelTermById(int id)
        {
            Level_Term lt = await _context.levelTerm.FindAsync(id);
            return lt;
        }
    }
}

using AdminDBHandler.Models.Dept_Level_Term;
using DatabaseHandler.Models_and_repositories.CommonRepository;

namespace DatabaseHandler.Models_and_repositories.Dept_Level_Term.repositories.LevelTermRepository
{
    public interface ILevelTermRepository : ICommonGenericRepository<Level_Term>
    {
        public Task<Level_Term> getLevelTermEntity(int level, string term);
        public Task<Level_Term> getLevelTermById(int id);
    }

}

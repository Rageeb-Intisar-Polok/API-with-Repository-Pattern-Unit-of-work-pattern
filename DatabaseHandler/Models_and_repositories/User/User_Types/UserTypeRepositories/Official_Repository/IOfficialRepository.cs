using AdminDBHandler.Models.User.User_Types;

namespace DatabaseHandler.Models_and_repositories.User.User_Types.UserTypeRepositories.Official_Repository
{
    public interface IOfficialRepository
    {
        public Task<Officials> GetOfficialByUniqueId(int individualId);
    }
}

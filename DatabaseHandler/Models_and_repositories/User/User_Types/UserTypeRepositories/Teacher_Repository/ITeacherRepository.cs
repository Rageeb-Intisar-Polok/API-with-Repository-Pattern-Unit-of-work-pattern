using AdminDBHandler.Models.User.User_Types;

namespace DatabaseHandler.Models_and_repositories.User.User_Types.UserTypeRepositories.Teacher_Repository
{
    public interface ITeacherRepository
    {
        public Task<Teachers> GetTeacherByUniqueId(int individualId);

    }
}

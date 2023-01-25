using DatabaseHandler.VisibleModels_to_addNewUser.Users;

namespace DatabaseHandler.Controllers.AboutUser.Works.AboutStudent
{
    public interface IGetInfoAboutStudentWork
    {
        public Task<Visible_student> getVisibleStudent(int individualId);
    }
}

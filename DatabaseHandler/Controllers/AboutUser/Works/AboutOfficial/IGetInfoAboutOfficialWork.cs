﻿using DatabaseHandler.VisibleModels_to_addNewUser.Users;

namespace DatabaseHandler.Controllers.AboutUser.Works.AboutOfficial
{
    public interface IGetInfoAboutOfficialWork
    {
        public Task<Visible_official> getVisibleOfficial(int individualId);
    }
}

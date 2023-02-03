﻿using Codesktop.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codesktop.Data
{
    public interface IForum
    {
        IForum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
    }
}
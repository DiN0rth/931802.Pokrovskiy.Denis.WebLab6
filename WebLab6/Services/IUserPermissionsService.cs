using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab6.Models;

namespace WebLab6.Services
{
    public interface IUserPermissionsService
    {
        Boolean CanEditPost(Post post);

        Boolean CanEditPostComment(PostComment postComment);
    }
}

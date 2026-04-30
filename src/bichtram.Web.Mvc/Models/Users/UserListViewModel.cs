using System.Collections.Generic;
using bichtram.Roles.Dto;

namespace bichtram.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

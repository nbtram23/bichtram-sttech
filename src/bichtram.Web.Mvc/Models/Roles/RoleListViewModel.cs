using System.Collections.Generic;
using bichtram.Roles.Dto;

namespace bichtram.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}

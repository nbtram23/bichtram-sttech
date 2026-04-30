using System.Collections.Generic;
using bichtram.Roles.Dto;

namespace bichtram.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
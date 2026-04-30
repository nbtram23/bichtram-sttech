using System.Threading.Tasks;
using Abp.Application.Services;
using bichtram.Sessions.Dto;

namespace bichtram.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

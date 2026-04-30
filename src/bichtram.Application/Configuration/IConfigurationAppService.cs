using System.Threading.Tasks;
using bichtram.Configuration.Dto;

namespace bichtram.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

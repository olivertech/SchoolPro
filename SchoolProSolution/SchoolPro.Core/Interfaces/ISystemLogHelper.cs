using System.Text.Json.Nodes;

namespace SchoolPro.Core.Interfaces
{
    public interface ISystemLogHelper
    {
        Task LogInformation(Guid userId, string action, JsonArray? json = null);
        Task LogWarning(Guid userId, string action, JsonArray? json = null);
        Task LogError(Guid userId, string action, JsonArray? json = null);
    }
}

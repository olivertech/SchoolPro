using System.Text.Json.Nodes;

namespace SchoolPro.Infra.Helpers
{
    /// <summary>
    /// Classe que responde pelo registro de todas 
    /// as ações realizadas pelo usuário no sistema
    /// </summary>
    public class SystemLogHelper : ISystemLogHelper
    {
        protected readonly IUnitOfWork? _unitOfWork;

        public SystemLogHelper(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task LogInformation(Guid userId, string action, JsonArray? json = null)
        {
            await _unitOfWork!.SystemLogRepository.Insert(new SystemLog()
            {
                UserId = userId,
                Action = action,
                Json = json != null ? json.ToString() : null,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                TimedAt = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss")),
                IsActive = true,
                Level = EnumInformationLevel.None
            });
        }

        public async Task LogWarning(Guid userId, string action, JsonArray? json = null)
        {
            await _unitOfWork!.SystemLogRepository.Insert(new SystemLog()
            {
                UserId = userId,
                Action = action,
                Json = json != null ? json.ToString() : null,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                TimedAt = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss")),
                IsActive = true,
                Level = EnumInformationLevel.Warning
            });
        }

        public async Task LogError(Guid userId, string action, JsonArray? json = null)
        {
            await _unitOfWork!.SystemLogRepository.Insert(new SystemLog()
            {
                UserId = userId,
                Action = action,
                Json = json != null ? json.ToString() : null,
                CreatedAt = DateOnly.FromDateTime(DateTime.Now),
                TimedAt = TimeOnly.Parse(DateTime.Now.ToString("HH:mm:ss")),
                IsActive = true,
                Level = EnumInformationLevel.Error
            });
        }
    }
}

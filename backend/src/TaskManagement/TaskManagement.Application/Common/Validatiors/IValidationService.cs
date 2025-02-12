namespace TaskManagement.Application.Common.Validatiors
{
    public interface IValidationService
    {
        Task<bool> ValidateAsync<T>(T request);
    }
}

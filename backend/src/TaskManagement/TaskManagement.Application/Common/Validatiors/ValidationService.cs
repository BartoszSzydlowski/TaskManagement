using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace TaskManagement.Application.Common.Validatiors
{
    public class ValidationService(IHttpContextAccessor httpContextAccessor) : IValidationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        public async Task<bool> ValidateAsync<T>(T request)
        {
            var validationResult = await _httpContextAccessor.HttpContext!.RequestServices.GetRequiredService<IValidator<T>>().ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            return true;
        }
    }
}

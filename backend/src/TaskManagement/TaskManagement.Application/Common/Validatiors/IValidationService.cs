using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Application.Common.Validatiors
{
    public interface IValidationService
    {
        Task<bool> ValidateAsync<T>(T request);
    }
}

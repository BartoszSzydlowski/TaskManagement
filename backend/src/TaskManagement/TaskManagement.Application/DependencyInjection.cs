using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Common.Validatiors;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.Requests;
using TaskManagement.Application.Services;
using TaskManagement.Application.Validators;

namespace TaskManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped(typeof(ITaskService<>), typeof(TaskService<>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITaskTypeService, TaskTypeService>();
            services.AddScoped<IValidationService, ValidationService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IValidator<AddTaskToUserRequest>, AddTaskToUserValidator>();

            return services;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using TaskManagement.Application.Requests;
using TaskManagement.Application.Services;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Validators
{
    public class AddTaskToUserValidator(ITaskRepository<Domain.Models.Task> taskRepository, IUserRepository userRepository) 
        : AbstractValidator<AddTaskToUserRequest>
    {
        private readonly ITaskRepository<Domain.Models.Task> _taskRepository = taskRepository;
        private readonly IUserRepository _userRepository = userRepository;

        public override Task<ValidationResult> ValidateAsync(ValidationContext<AddTaskToUserRequest> context, CancellationToken cancellation = default)
        {
            RuleFor(x => x)
                .Must(MaxTenTasksPerRequest)
                .WithMessage("Only ten tasks at once can be assigned");
            return base.ValidateAsync(context, cancellation);
        }

        private bool MaxTenTasksPerRequest(AddTaskToUserRequest request)
        {
            var tasksCount = request.TasksIds.Length;
            return tasksCount <= 10;
        }
    }
}

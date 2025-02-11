using FluentValidation;
using FluentValidation.Results;
using TaskManagement.Application.Requests;
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

            RuleFor(x => x)
                .MustAsync(HaveBetweenFiveAndElevenTasks)
                .WithMessage("User must have at least 5 or max 11 tasks assigned");

            RuleFor(x => x)
                .MustAsync(CheckUserType)
                .WithMessage("Programmer can't be assigned maintenance and deployment tasks");

            RuleFor(x => x)
                .MustAsync(HaveValidDifficultyDistribution)
                .WithMessage("User assigned has tasks properly distributed around their difficulty");

            return base.ValidateAsync(context, cancellation);
        }

        private async Task<bool> CheckUserType(AddTaskToUserRequest request, CancellationToken cancellation = default)
        {
            var user = await _userRepository.Get(request.UserId);
            var userType = user.UserType.Id;
            foreach (var id in request.TasksIds)
            {
                var task = await _taskRepository.Get(id);
                if ((task.TaskType.Id is 1 or 2) && userType is 1)
                {
                    return false;
                }
            }

            return true;
        }

        private async Task<bool> HaveBetweenFiveAndElevenTasks(AddTaskToUserRequest request, CancellationToken cancellation = default)
        {
            var tasks = await _taskRepository.GetUserTasks(request.UserId);
            return tasks.Count is >= 5 and <= 11;
        }

        private bool MaxTenTasksPerRequest(AddTaskToUserRequest request)
        {
            var tasksCount = request.TasksIds.Length;
            return tasksCount <= 10;
        }

        private async Task<bool> HaveValidDifficultyDistribution(AddTaskToUserRequest request, CancellationToken cancellation = default)
        {
            var existingTasks = await _taskRepository.GetUserTasks(request.UserId);

            var totalTasks = existingTasks.Count + request.TasksIds.Length;
            if (totalTasks == 0) return true;

            var highDifficultyCount = existingTasks.Count(t => t.Difficulty is 4 or 5);
            var lowDifficultyCount = existingTasks.Count(t => t.Difficulty is 1 or 2);

            foreach (var taskId in request.TasksIds)
            {
                var task = await _taskRepository.Get(taskId);
                if (task.Difficulty is 4 or 5) highDifficultyCount++;
                if (task.Difficulty is 1 or 2) lowDifficultyCount++;
            }

            var highDifficultyPercentage = (double)highDifficultyCount / totalTasks * 100;
            var lowDifficultyPercentage = (double)lowDifficultyCount / totalTasks * 100;

            return highDifficultyPercentage is >= 10 and <= 30 && lowDifficultyPercentage <= 50;
        }
    }
}

using AutoMapper;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Common.Validatiors;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.Requests;
using TaskManagement.Application.ViewModels.Task;
using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class TaskService<T>(ITaskRepository<Domain.Models.Task> repository, IMapper mapper, IValidationService validationService)
        : ITaskService<T>
        where T : TaskViewModel
    {
        private readonly ITaskRepository<Domain.Models.Task> _repository = repository;
        private readonly IMapper _mapper = mapper;
        private readonly IValidationService _validationService = validationService;

        public async Task<ListResponse<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(Status? status, int taskTypeId, int? userId)
        {
            var data = await _repository.GetFilteredByTaskTypeAndSortedByDifficultyDesc(status, taskTypeId, userId);
            var count = await _repository.GetTotalCount(taskTypeId, userId, status);

            return new ListResponse<T>
            {
                Data = _mapper.Map<List<T>>(data),
                Total = count,
            };
        }

        public async Task<BaseResponse> AddTaskToUser(AddTaskToUserRequest request)
        {
            await _validationService.ValidateAsync(request);
            await _repository.AddTaskToUser(request.TasksIds, request.UserId);
            return new BaseResponse();
        }

        public async Task<Domain.Models.Task> Get(int id)
        {
            return await _repository.Get(id);
        }
    }
}

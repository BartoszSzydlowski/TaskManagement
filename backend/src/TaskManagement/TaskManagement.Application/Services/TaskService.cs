using AutoMapper;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.Requests;
using TaskManagement.Application.ViewModels.TaskViewModel;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class TaskService<T>(ITaskRepository<Domain.Models.Task> repository, IMapper mapper) : ITaskService<T> where T : TaskViewModel
    {
        private readonly ITaskRepository<Domain.Models.Task> _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<PagedResponse<T>> GetFilteredByTaskTypeAndSortedByDifficultyDesc(int pageNumber, int pageSize, int taskTypeId, int? userId)
        {
            var data = await _repository.GetFilteredByTaskTypeAndSortedByDifficultyDesc(pageNumber, pageSize, taskTypeId, userId);
            var count = await _repository.GetTotalCount(taskTypeId, userId);

            return new PagedResponse<T>
            {
                Data = _mapper.Map<List<T>>(data),
                TotalCount = count,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public async Task<BaseResponse> AddTaskToUser(AddTaskToUserRequest request)
        {
            await _repository.AddTaskToUser(request.TasksIds, request.UserId);
            return new BaseResponse();
        }

        public async Task<Domain.Models.Task> Get(int id)
        {
            return await _repository.Get(id);
        }
    }
}

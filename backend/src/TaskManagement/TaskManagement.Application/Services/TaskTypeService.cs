using AutoMapper;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.TaskTypeViewModel;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class TaskTypeService(ITaskTypeRepository repository, IMapper mapper) : ITaskTypeService
    {
        private readonly ITaskTypeRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<ListResponse<TaskTypeViewModel>> GetAll()
        {
            var data = await _repository.GetAll();
            return new ListResponse<TaskTypeViewModel>
            {
                Data = _mapper.Map<List<TaskTypeViewModel>>(data),
                Total = data.Count
            };
        }
    }
}

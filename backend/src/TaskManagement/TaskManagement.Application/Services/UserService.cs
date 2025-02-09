using AutoMapper;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.User;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.Services
{
    public class UserService(IUserRepository repository, IMapper mapper) : IUserService
    {
        private readonly IUserRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<ListResponse<UserViewModel>> GetAll()
        {
            var data = await _repository.GetAll();
            return new ListResponse<UserViewModel>
            {
                Data = _mapper.Map<List<UserViewModel>>(data),
                Total = data.Count
            };
        }
    }
}

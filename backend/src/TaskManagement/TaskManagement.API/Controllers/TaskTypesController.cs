using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.TaskTypeViewModel;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaskTypesController(ITaskTypeService service) : ControllerBase
    {
        private readonly ITaskTypeService _service = service;

        [HttpGet]
        public async Task<ListResponse<TaskTypeViewModel>> GetAll()
        {
            return await _service.GetAll();
        }
    }
}

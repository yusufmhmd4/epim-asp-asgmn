using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.ToDoItems
{
    public interface IToDoItemAppService : IApplicationService
    {
        Task<List<ToDoItemDto>> GetAll();
        Task<ToDoItemDto> Create(ToDoItemDto input);
        Task Update(ToDoItemDto input);
        Task Delete(int id);
        Task UpdateIsCompleted(int id);
        Task UpdateDescription(int id, string newDescription);
    }
}

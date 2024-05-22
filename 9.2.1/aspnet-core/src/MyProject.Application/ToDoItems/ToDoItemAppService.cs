using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.ToDoItems
{
    public class ToDoItemAppService : ApplicationService, IToDoItemAppService
    {
        private readonly IRepository<ToDoItem, int> _toDoItemRepository;

        public ToDoItemAppService(IRepository<ToDoItem, int> toDoItemRepository)
        {
            _toDoItemRepository = toDoItemRepository;
        }

        // Getting all Todo items
        public async Task<List<ToDoItemDto>> GetAll()
        {
            var items = await _toDoItemRepository.GetAllListAsync();
            return ObjectMapper.Map<List<ToDoItemDto>>(items);

        }


        // Creating a new Todo item
        public async Task<ToDoItemDto> Create(ToDoItemDto input)
        {
            var item = ObjectMapper.Map<ToDoItem>(input);
            await _toDoItemRepository.InsertAsync(item);
            return ObjectMapper.Map<ToDoItemDto>(item);
        }

        // Getting a specific Todo item
        public async Task<ToDoItemDto> Get(int id)
        {
            var item = await _toDoItemRepository.GetAsync(id);
            return ObjectMapper.Map<ToDoItemDto>(item);
        }

        // Updatig a specific Todo item
        public async Task Update(ToDoItemDto input)
        {
            var item = await _toDoItemRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, item);
        }

        // Deleting a specific Todo item
        public async Task Delete(int id)
        {
            await _toDoItemRepository.DeleteAsync(id);
        }

        // Updating the IsCompleted status of a specific Todo item
        public async Task UpdateIsCompleted(int id)
        {
            var item = await _toDoItemRepository.GetAsync(id);
            item.IsCompleted = !item.IsCompleted;
            await _toDoItemRepository.UpdateAsync(item);
        }

        // Updating the description of a specific Todo item
        public async Task UpdateDescription(int id, string newDescription)
        {
            var item = await _toDoItemRepository.GetAsync(id);
            item.Description = newDescription;
            await _toDoItemRepository.UpdateAsync(item);
        }
    }
}

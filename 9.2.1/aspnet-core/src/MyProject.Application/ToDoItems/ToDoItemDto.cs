using Abp.Application.Services.Dto;

namespace MyProject.ToDoItems
{
    public class ToDoItemDto : EntityDto<int>
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}

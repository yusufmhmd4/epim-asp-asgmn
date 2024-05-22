using AutoMapper;
using MyProject.ToDoItems;

namespace MyProject
{
    public class ToDoItemMapProfile : Profile
    {
        public ToDoItemMapProfile()
        {
            CreateMap<ToDoItem, ToDoItemDto>();
            CreateMap<ToDoItemDto, ToDoItem>();
        }
    }
}

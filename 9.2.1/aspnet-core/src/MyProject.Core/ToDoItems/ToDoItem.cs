using Abp.Domain.Entities;


namespace MyProject.ToDoItems
{
    public class ToDoItem : Entity<int>
    {


        public string Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}

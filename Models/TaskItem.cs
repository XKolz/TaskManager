// public class TaskItem
// {
//     public int Id { get; set; }
//     public string Title { get; set; }
//     public bool IsCompleted { get; set; }
// }
namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        // public string Title { get; set; }
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }
    }
}

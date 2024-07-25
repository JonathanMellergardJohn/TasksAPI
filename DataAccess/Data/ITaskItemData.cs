using DataAccess.Models;

namespace DataAccess.Data
{
    public interface ITaskItemData
    {
        Task DeletetTaskItem(int id);
        Task<TaskItem?> GetTaskItemById(int id);
        Task<IEnumerable<TaskItem>> GetTaskItems();
        Task<IEnumerable<TaskItem>> GetTaskItemsByList(int listId);
        Task PostTaskItem(TaskItem newList);
        Task PutTaskItem(TaskItem updatedList);
    }
}
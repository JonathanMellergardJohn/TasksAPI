using DataAccess.DbAccess;
using DataAccess.Models;
using DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class TaskItemData : ITaskItemData
    {
        private readonly ISqlDataAccess _db;

        public TaskItemData(ISqlDataAccess db)
        {
            _db = db;
        }
        // get ONE task item by id

        public async Task<TaskItem?> GetTaskItemById(int id)
        {
            var results = await _db.LoadData<TaskItem, dynamic>(SqlTaskItem.GetOneById, new { Id = id });
            return results.FirstOrDefault();
        }
        // get ALL task items
        public Task<IEnumerable<TaskItem>> GetTaskItems()
        {
            return _db.LoadData<TaskItem, dynamic>(SqlTaskItem.GetAll, new { });
        }
        // get ALL task items by list id
        public Task<IEnumerable<TaskItem>> GetTaskItemsByList(int listId)
        {
            return _db.LoadData<TaskItem, dynamic>(SqlTaskItem.GetAllByListId, new { ListId = listId });
        }
        // add list
        public Task PostTaskItem(TaskItem newList) =>
            _db.SaveData<dynamic>(SqlTaskItem.PostOne, newList);
        // edit list
        public Task PutTaskItem(TaskItem updatedList) =>
            _db.SaveData<dynamic>(SqlTaskItem.PutOne, updatedList);
        // delete list
        public Task DeletetTaskItem(int id) =>
            _db.SaveData<dynamic>(SqlTaskItem.DeleteOne, new { Id = id });
    }
}

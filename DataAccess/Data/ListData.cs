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
    public class ListData : IListData
    {
        private readonly ISqlDataAccess _db;

        public ListData(ISqlDataAccess db)
        {
            _db = db;
        }
        // get ONE list by id

        public async Task<List?> GetList(int id)
        {
            var results = await _db.LoadData<List, dynamic>(SqlList.GetOne, new { Id = id });
            return results.FirstOrDefault();
        }
        // get ALL lists
        public Task<IEnumerable<List>> GetLists()
        {
            return _db.LoadData<List, dynamic>(SqlList.GetAll, new { });
        }
        // add list
        public Task PostList(List newList) =>
            _db.SaveData<dynamic>(SqlList.PostOne, newList);
        // edit list
        public Task PutList(List updatedList) =>
            _db.SaveData<dynamic>(SqlList.PutOne, updatedList);
        // delete list
        public Task DeleteList(int id) =>
            _db.SaveData<dynamic>(SqlList.DeleteOne, new { Id = id });
    }
}

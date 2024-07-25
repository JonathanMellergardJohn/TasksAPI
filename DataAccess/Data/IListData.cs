using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IListData
    {
        Task DeleteList(int id);
        Task<List?> GetList(int id);
        Task<IEnumerable<List>> GetLists();
        Task PostList(List newList);
        Task PutList(List updatedList);
    }
}
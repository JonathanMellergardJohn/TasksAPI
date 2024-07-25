using DataAccess.Data;
using DataAccess.Models;

namespace API
{
    public static class ListApi
    {
        // Configure List endpoints
        public static void ConfigureListApi(this WebApplication app)
        {
            
            app.MapGet(pattern: "/Lists/{id}", GetList);
            app.MapGet(pattern: "/Lists", GetLists);
            app.MapPost(pattern: "/Lists", PostList);
            app.MapPut(pattern: "/Lists", PutList);
            app.MapDelete(pattern: "/Lists", DeleteList);
        }

        // List functions
        private static async Task<IResult> GetList(int id, IListData data) 
        {
            try
            {
                return Results.Ok(await data.GetList(id));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> GetLists(IListData data)
        {
            try
            {
                return Results.Ok(await data.GetLists());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> PostList(List newList, IListData data)
        {
            try
            {
                await data.PostList(newList);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> PutList(List updatedList, IListData data)
        {
            try
            {
                await data.PutList(updatedList);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteList(int id, IListData data)
        {
            try
            {
                await data.DeleteList(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}

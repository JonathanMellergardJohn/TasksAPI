using DataAccess.Data;
using DataAccess.Models;

namespace API
{
    public static class TaskItemApi
    {
        // Configure List endpoints
        public static void ConfigureTaskItemApi(this WebApplication app)
        {

            app.MapGet(pattern: "TaskItems/{id}", GetTaskItemById);
            app.MapGet(pattern: "TaskItems/Lists/{listId}", GetTaskItemByListId);
            app.MapGet(pattern: "TaskItems/", GetTaskItems);
            app.MapPost(pattern: "TaskItems/", PostTaskItem);
            app.MapPut(pattern: "TaskItems/", PutTaskItem);
            app.MapDelete(pattern: "TaskItems/", DeleteTaskItem);
        }

        // List functions
        private static async Task<IResult> GetTaskItemById(int id, ITaskItemData data)
        {
            try
            {
                return Results.Ok(await data.GetTaskItemById(id));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> GetTaskItemByListId(int listId, ITaskItemData data)
        {
            try
            {
                return Results.Ok(await data.GetTaskItemsByList(listId));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> GetTaskItems(ITaskItemData data)
        {
            try
            {
                return Results.Ok(await data.GetTaskItems());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> PostTaskItem(TaskItem newTaskItem, ITaskItemData data)
        {
            try
            {
                await data.PostTaskItem(newTaskItem);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> PutTaskItem(TaskItem updatedList, ITaskItemData data)
        {
            try
            {
                await data.PutTaskItem(updatedList);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteTaskItem(int id, ITaskItemData data)
        {
            try
            {
                await data.DeletetTaskItem(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}

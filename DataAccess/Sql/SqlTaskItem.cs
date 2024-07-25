using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Sql
{
    public class SqlTaskItem
    {
        public const string GetOneById = @"
            SELECT Id, Name, IsCompleted, Latitude, Longitude, ListId
            FROM dbo.TaskItem
            WHERE Id = @Id";
        public const string GetAll = @"
            SELECT Id, Name, IsCompleted, Latitude, Longitude, ListId
            FROM dbo.TaskItem";
        public const string GetAllByListId = @"
            SELECT Id, Name, IsCompleted, Latitude, Longitude, ListId
            FROM dbo.TaskItem
            WHERE ListId = @ListId";
        public const string PostOne = @"
            INSERT INTO dbo.TaskItem (Name, IsCompleted, Latitude, Longitude, ListId)
            VALUES (@Name, @IsCompleted, @Latitude, @Longitude, @ListId)";
        public const string PutOne = @"
            UPDATE dbo.TaskItem
            SET 
                Name = @Name, 
                IsCompleted = @IsCompleted, 
                Latitude = @Latitude, 
                Longitude = @Longitude, 
                ListId = @ListId
            WHERE Id = @Id";
        public const string DeleteOne = @"
            DELETE FROM dbo.TaskItem
            WHERE Id = @Id";
    }
}

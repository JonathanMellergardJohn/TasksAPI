using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Sql
{
    public class SqlList
    {
        public const string GetOne = @"
            SELECT Id, Name
            FROM dbo.List
            WHERE Id = @Id";
        public const string GetAll = @"
            SELECT Id, Name
            FROM dbo.List";
        public const string PostOne = @"
            INSERT INTO dbo.List (Name)
            VALUES (@Name)";
        public const string PutOne = @"
            UPDATE dbo.List
            SET Name = @Name
            WHERE Id = @Id";
        public const string DeleteOne = @"
            DELETE FROM dbo.List
            WHERE Id = @Id";
    }
}

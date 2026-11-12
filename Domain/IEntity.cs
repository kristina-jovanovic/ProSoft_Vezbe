using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string Join { get; }

        List<IEntity> GetReaderList(SqlDataReader reader);
    }
}

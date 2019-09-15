using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.SQLite
{
    public sealed class AreasSQLite : IAreaRepository
    {
        public IReadOnlyList<AreaEntity> Getdata()
        {
            string sql = @"select AreaID,AreaName from Areas";

            return SQLiteHelper.Query(sql,
                reader =>
                {
                    return new AreaEntity(Convert.ToInt32(reader["AreaID"]),
                            Convert.ToString(reader["AreaName"]));
                }
                );
        }


    }

        
   
}

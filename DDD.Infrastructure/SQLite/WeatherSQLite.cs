using DDD.Domain.Entities;
using DDD.Domain.Repositories;

using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace DDD.Infrastructure.SQLite
{
    public class WeatherSQLite : IWeatherRepository
    {
        

        public WeatherEntity GetLatest(int areaID)
        {
            string sql = @"select DataDate,
Condition,
Temparture
from Weather
where AreaID=@AreaID
order by DataDate desc
LIMIT 1";
            return SQLiteHelper.QuerySingle(
                sql,
                new List<SQLiteParameter>
                {
                    new SQLiteParameter("@AreaID", areaID)
        }.ToArray(),
        reader=>{
             return new WeatherEntity(
                            areaID,
                            Convert.ToDateTime(reader["DataDate"]),
                            Convert.ToInt32(reader["Condition"]),
                            Convert.ToSingle(reader["Temparture"])); },
    null);

        }

        public IReadOnlyList<WeatherEntity> GetData()
        {
            string sql = @"
select A.AreaID,ifnull(B.AreaName,'') AS AreaName,A.DataDate,
A.Condition,
A.Temparture
from Weather A
left outer join Areas B
on A.AreaID=B.AreaID";

            return SQLiteHelper.Query(sql, reader =>
            {
                return new WeatherEntity(
                           Convert.ToInt32(reader["AreaID"]),
                            Convert.ToString(reader["AreaName"]),
                           Convert.ToDateTime(reader["DataDate"]),
                           Convert.ToInt32(reader["Condition"]),
                           Convert.ToSingle(reader["Temparture"]))

            ;
            });        
        }

        public void Save(WeatherEntity weather)
        {
            string insert= @"
insert into Weather 
(AreaID,DataDate,Condition,Temparture)
values
(@AreaID,@DataDate,@Condition,@Temparture)";



            string update = @"
update Weather
set Condition=@Condition,
Temparture=@Temparture
where AreaID=@AreaID
and DataDate=@DataDate";


            var args = new List<SQLiteParameter>
            {
                new SQLiteParameter("@AreaID",weather.AreaID.Value),
                new SQLiteParameter("@DataDate",weather.DataDate),
                new SQLiteParameter("@Condition",weather.Condition.Value),
                new SQLiteParameter("@Temparture",weather.Temparture.Value),
            };

            SQLiteHelper.Execute(insert, update, args.ToArray());

        }
    }
}

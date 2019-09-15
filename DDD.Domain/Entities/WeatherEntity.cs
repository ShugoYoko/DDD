
using DDD.Domain.ValueObjects;
using System;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        //完全コンストラクターパターン
        public WeatherEntity(int areaID,
        DateTime dataDate,
        int condition,
        float temparture):
            this(areaID,string.Empty,dataDate,condition,temparture)
        {
            
        }

        public WeatherEntity(int areaID,
            string areaName,
       DateTime dataDate,
       int condition,
       float temparture)
        {
            AreaID = new AreaId(areaID);
            AreaName = areaName;
            DataDate = dataDate;
            Condition = new Condition(condition);
            Temparture = new Temparture(temparture);
        }


        //読み取り専用
        public AreaId AreaID { get;  }
        public string AreaName { get; }
        public DateTime DataDate { get;  }
        public Condition Condition { get;  }
        public Temparture Temparture { get; }

        //上記の値を使ったロジックを下に書く

        public bool IsMousho()
        {
            if (Condition == Condition.Sunny)
            {
                if (Temparture.Value > 30)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

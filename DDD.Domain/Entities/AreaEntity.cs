

namespace DDD.Domain.Entities
{
    public sealed class AreaEntity
    {
       public AreaEntity(int areaID,string areaName)
        {
            AreaID = areaID;
            AreaName = areaName;

        } 

        public int AreaID { get; }
        public string AreaName { get; }
    }
}

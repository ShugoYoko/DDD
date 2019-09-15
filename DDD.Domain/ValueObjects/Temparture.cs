

using DDD.Domain.Helpers;


namespace DDD.Domain.ValueObjects
{
    public sealed class Temparture:ValueObject<Temparture>
    {
        public const string UnitName = "℃";
        public const int DecimalPoint = 2;

        public Temparture(float value)
        {
            Value = value;
        }

        public float Value { get; }
        public string DisplayValue
        {
            get
            {
                return Value.RoundString( DecimalPoint);
            }
        }

        public string DisplayValueWithUnit
        {
            get
            {
                return Value.RoundString(DecimalPoint) + UnitName;
            }
        }

        public string DisplayValueWithUnitSpace
        {
            get
            {
                return Value.RoundString(DecimalPoint) +" "+ UnitName;
            }
        }

        protected override bool EqualsCore(Temparture other)
        {
            return Value==other.Value;
        }
    }
}

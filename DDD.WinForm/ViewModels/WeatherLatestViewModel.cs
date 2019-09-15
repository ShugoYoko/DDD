using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using DDD.Infrastructure.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class WeatherLatestViewModel:ViewModelBase
    {
        private IWeatherRepository _weather;
        IAreaRepository _areas;

        public WeatherLatestViewModel():this(new WeatherSQLite(),new AreasSQLite())
        {
           
        }

        public WeatherLatestViewModel(IWeatherRepository weather,IAreaRepository areas)
        {
            _weather = weather;
            _areas = areas;

            foreach(var area in _areas.Getdata())
            {
                Areas.Add(new AreaEntity(area.AreaID,area.AreaName));
            }
        }

        private object _selectedAreaID;
        public object SelectedAreaID
        {
            get
            { return _selectedAreaID; }
            //データバインドのため
            set
            {
                SetProperty(ref _selectedAreaID, value);

            }
        }

        private string _dataDateText = string.Empty;
        public string DataDateText
        {
            get
            { return _dataDateText; }
            set
            {
                SetProperty(ref _dataDateText, value);

            }
        }

        private string _conditionText = string.Empty;
        public string ConditionText
        {
            get
            { return _conditionText; }
            set
            {
                SetProperty(ref _conditionText, value);

            }
        }

        private string _tempartureText = string.Empty;
        public string TempartureText
        {
            get
            { return _tempartureText; }
            set
            {
                SetProperty(ref _tempartureText, value);

            }
        }

        public BindingList<AreaEntity> Areas { get; set; }
        = new BindingList<AreaEntity>();

        public void Search()
        {
            var entity=_weather.GetLatest(Convert.ToInt32(_selectedAreaID));

            if (entity == null)
            {
                DataDateText = string.Empty;
                ConditionText = string.Empty;
                TempartureText = string.Empty;
            }
            else
            {
                DataDateText = entity.DataDate.ToString();
                ConditionText =entity.Condition.DisplayValue;
                TempartureText = entity.Temparture.DisplayValueWithUnitSpace;
                
            }

           
        }

       
    }
}

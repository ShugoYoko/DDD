using DDD.Domain.Entities;
using DDD.Domain.ValueObjects;
using DDD.WinForm.ViewModels;
using System;
using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    public partial class WeatherSaveView : Form
    {

        private WeatherSaveViewModel _viewmodel
           = new WeatherSaveViewModel();

        public WeatherSaveView()
        {     


            InitializeComponent();

            this.AreIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AreIdComboBox.DataBindings.Add(
                "SelectedValue", _viewmodel, nameof(_viewmodel.SelectedAreaId));
            this.AreIdComboBox.DataBindings.Add(
               "DataSource", _viewmodel, nameof(_viewmodel.Areas));
            this.AreIdComboBox.ValueMember = nameof(AreaEntity.AreaID);
            this.AreIdComboBox.DisplayMember = nameof(AreaEntity.AreaName);

            DateTimeComboBox.DataBindings.Add(
                "Value", _viewmodel, nameof(_viewmodel.DataDateValue));

            this.ConditionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ConditionComboBox.DataBindings.Add(
                "SelectedValue", _viewmodel, nameof(_viewmodel.SelectedCondition));
            this.ConditionComboBox.DataBindings.Add(
               "DataSource", _viewmodel, nameof(_viewmodel.Conditions));
            this.ConditionComboBox.ValueMember = nameof(Condition.Value);
            this.ConditionComboBox.DisplayMember = nameof(Condition.DisplayValue);

            TempartureTextBox.DataBindings.Add(
                "Text", _viewmodel, nameof(_viewmodel.TemperatureText));

            UnitLabel.DataBindings.Add(
               "Text", _viewmodel, nameof(_viewmodel.TemperatureUnitName));

            SaveButton.Click += (_, __) =>
            {
                try
                {
                    _viewmodel.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            };

        }
    }
}

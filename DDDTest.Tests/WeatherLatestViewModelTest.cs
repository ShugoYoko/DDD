using System;
using System.Collections.Generic;
using System.Data;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var weatherMock = new Mock<IWeatherRepository>();
            weatherMock.Setup(x => x.GetLatest(1)).Returns(
                new WeatherEntity(
                    1,
                Convert.ToDateTime("2018/01/01 12:34:56"),
                2,
                12.3f));

            var areas = new List<AreaEntity>();
            areas.Add(new AreaEntity(1, "東京"));
            areas.Add(new AreaEntity(2, "神戸"));
            areas.Add(new AreaEntity(3, "沖縄"));

            var areaMock = new Mock<IAreaRepository>();
            areaMock.Setup(x => x.Getdata()).Returns(areas);
            //初期値
            var viewModel = new WeatherLatestViewModel(weatherMock.Object,areaMock.Object);
            Assert.IsNull( viewModel.SelectedAreaID);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TempartureText);
            Assert.AreEqual(3, viewModel.Areas.Count);

            //直近値をもってくる
            viewModel.SelectedAreaID = 1;
            viewModel.Search();
            Assert.AreEqual(1, viewModel.SelectedAreaID);
            Assert.AreEqual("2018/01/01 12:34:56", viewModel.DataDateText);
            Assert.AreEqual("曇り", viewModel.ConditionText);
            Assert.AreEqual("12.30 ℃", viewModel.TempartureText);

            //直近値をもってくる
            viewModel.SelectedAreaID = 3;
            viewModel.Search();
            Assert.AreEqual(3, viewModel.SelectedAreaID);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TempartureText);

        }
    }

    
}

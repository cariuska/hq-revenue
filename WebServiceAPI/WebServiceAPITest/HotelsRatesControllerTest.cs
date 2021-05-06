using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebServiceAPI.Controllers;
using WebServiceAPI.Services;
using Microsoft.AspNetCore.Mvc;
using WebServiceAPI.Models;

namespace WebServiceAPITest
{

    public class HotelsRatesControllerTest
    {

        HotelsRatesController _controller;
        HotelsRatesServicesFake _service;


        [SetUp]
        public void Setup()
        {
            _service = new HotelsRatesServicesFake();
            _controller = new HotelsRatesController(_service);
        }

        [Test]
        public void GetHotelsTest()
        {
            var okResult = _controller.Get(1, Convert.ToDateTime("2016-03-14T20:00:00-03:00"));

            Assert.AreEqual(1, okResult.hotel.hotelID);
            Assert.AreEqual(1, okResult.hotelRates.Count);
            Assert.AreEqual(Convert.ToDateTime("2016-03-14T20:00:00-03:00"), okResult.hotelRates[0].targetDay);
        }


        [Test]
        public void GetHotelsNewDateTest()
        {
            var okResult = _controller.Get(1, new DateTime());

            Assert.AreEqual(2, okResult.hotelRates.Count);
        }


        [Test]
        public void GetHotelsIdNotExistsTest()
        {
            var okResult = _controller.Get(3, new DateTime());

            Assert.AreEqual(0, okResult.hotelRates.Count);
        }



    }
}

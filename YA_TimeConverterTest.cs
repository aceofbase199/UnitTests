using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestProject1.TimeConverter;

namespace TestProject1
{
    [TestFixture]
    public class TimeConverterTest
    {
        [Test]
        public void Time_Converter_Return_EasternTime()
        {
            //Arrange
            var timeAtTheMoment = DateTime.Now;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var expectedtimeAtTheMomentEast =  TimeZoneInfo.ConvertTime(timeAtTheMoment, TimeZoneInfo.Local, easternZone);
            //Act
            var actualTimeAtTheMomentEast = TimeZoneConverter.ConvertToEst(timeAtTheMoment);
            //Assert
            Assert.AreEqual(expectedtimeAtTheMomentEast,actualTimeAtTheMomentEast);
        }
        [Test]
        public void Time_Converter_Return_UTCTime()
        {
            //Arrange
            var timeAtTheMoment = DateTime.Now;
            var expectedtimeAtTheMomentUTC = DateTime.UtcNow;
            //Act
            var actualTimeAtTheMomentUTC = TimeZoneConverter.ConvertToUtc(timeAtTheMoment);
            //Assert
            Assert.AreEqual(expectedtimeAtTheMomentUTC.Date, actualTimeAtTheMomentUTC.Date);
        }
    }
}

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
            var timeAtTheMomentEast =  TimeZoneInfo.ConvertTime(timeAtTheMoment, TimeZoneInfo.Local, easternZone);
            //Assert
            Assert.AreEqual(timeAtTheMomentEast, TimeZoneConverter.ConvertToEst(timeAtTheMoment));
        }
        [Test]
        public void Time_Converter_Return_UTCTime()
        {
            //Arrange
            var timeAtTheMoment = DateTime.Now;
            var timeAtTheMomentUTC = DateTime.UtcNow;
            //Assert
            Assert.AreEqual(timeAtTheMomentUTC.Date, TimeZoneConverter.ConvertToUtc(timeAtTheMoment).Date);
        }
    }
}

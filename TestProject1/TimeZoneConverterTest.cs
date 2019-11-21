using System;
using NUnit.Framework;
using TestProject1.TimeConverter;

namespace TestProject1
{
    public class TimeZoneConverterTest
    {
        [Test]
        public void TimeZone_Is_Converted_To_EasternTimeZone()
        {
            var timeShouldBe = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Eastern Standard Time");
            var timeIs = TimeZoneConverter.ConvertToEst(DateTime.Now);

            Assert.AreEqual(timeShouldBe.Second, timeIs.Second);
        }

        [Test]
        public void TimeZone_Is_Converted_To_UTC()
        {
            var timeShouldBe = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            var timeIs = TimeZoneConverter.ConvertToUtc(DateTime.Now);
            Assert.AreEqual(timeShouldBe.Second, timeIs.Second);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.ConvertToDataGridView;

namespace AppTest
{
    [TestClass]
    public class ToUserFriendlyTest
    {
        private ToUserFriendly toUserFriendly;

        [TestMethod]
        public void ConvertDurationTest()
        {
            toUserFriendly = new ToUserFriendly();
            var d1 = toUserFriendly.ConvertDuration("03d10:58:15");
            var d2 = toUserFriendly.ConvertDuration("10d00:00:00");

            Assert.AreEqual("3 d 10 h 58 min", d1);
            Assert.AreEqual("10 d", d2);
        }

        [TestMethod]
        public void ConvertDepartureTime()
        {
            toUserFriendly = new ToUserFriendly();

            var dt1 = toUserFriendly.ConvertDepartureTime("2018-12-04T11:02:00+0100");
            var dt2 = toUserFriendly.ConvertDepartureTime("2018-12-04T15:35:00+0500");

            Assert.AreEqual("12:02", dt1);
            Assert.AreEqual("20:35", dt2);
        }
    }
}

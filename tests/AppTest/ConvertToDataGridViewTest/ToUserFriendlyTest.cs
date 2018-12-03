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
            var duration = "03d10:58:15";

            Assert.AreEqual("3 d 10 h 58 min", duration);
        }

        public void ConvertDepartureTime()
        {
            toUserFriendly = new ToUserFriendly();
            //var departureTime = 
        }
    }
}

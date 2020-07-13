using System.Collections.Generic;
using BLL;
using BLL.Interfaces;
using BLL.PaymentType;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BLLUnitTest
{
    [TestClass]
    public class BLLTest
    {
        Payment paymentType = new Payment();

        [TestMethod]
        public void GenerateProductSlipTest()
        {
            IPayment obj = paymentType.GetObject("Product");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("product", "Hard Drive");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GenerateBookSlipTest()
        {
            IPayment obj = paymentType.GetObject("Book");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("book", "nobel");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ActivateMembershipTest()
        {
            IPayment obj = paymentType.GetObject("Membership");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("userType", "New");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpgradeMembershipTest()
        {
            IPayment obj = paymentType.GetObject("Membership");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("userType", "Old");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ActivateMembershipMailTest()
        {
            IPayment obj = paymentType.GetObject("Membership");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("userType", "New");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GenerateVideoLearningSlipTest()
        {
            IPayment obj = paymentType.GetObject("VideoLearning");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("video", "technical");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductCommisionPaymentTest()
        {
            IPayment obj = paymentType.GetObject("Product");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("product", "Hard Drive");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BookCommisionPaymentTest()
        {
            IPayment obj = paymentType.GetObject("Book");
            Dictionary<string, string> input = new Dictionary<string, string>();
            input.Add("book", "nobel");
            string expected = "success";

            string actual = obj.Process(input);

            Assert.AreEqual(expected, actual);
        }
    }
}

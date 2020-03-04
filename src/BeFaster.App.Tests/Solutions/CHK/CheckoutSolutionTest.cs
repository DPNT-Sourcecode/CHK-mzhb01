using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    public class CheckoutSolutionTest
    {
        [Test]
        public void ComputePrice_Returns_0_When_The_Given_Parameter_Is_Empty()
        {
            var totalPrice = CheckoutSolution.ComputePrice("");

            Assert.AreEqual(0, totalPrice);
        }

        [Test]
        public void ComputePrice_Returns_The_Correct_Total_Price()
        {
            var totalPrice = CheckoutSolution.ComputePrice("AAAAD");

            Assert.AreEqual(195, totalPrice);
        }

        [Test]
        public void ComputePrice_Returns_The_Correct_Total_Price_With_Multiple_Offers()
        {
            var totalPrice = CheckoutSolution.ComputePrice("AAAAAAAABBCD");

            Assert.AreEqual(440, totalPrice);
        }

        [Test]
        public void ComputePrice_Returns_Minus_1_When_The_Given_Input_Is_Incorrect()
        {
            var totalPrice = CheckoutSolution.ComputePrice("F1AA3LCD");

            Assert.AreEqual(-1, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price()
        {
            var totalPrice = CheckoutSolution.Checkout("AAAABDEE");

            Assert.AreEqual(355, totalPrice);
        }
    }
}


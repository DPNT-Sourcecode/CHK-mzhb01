using BeFaster.App.Solutions.CHK;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.CHK
{
    public class CheckoutSolutionTest
    {
        [Test]
        public void ComputePrice_Returns_The_Correct_Total_Price()
        {
            var totalPrice = CheckoutSolution.ComputePrice("A,A,A,A,D");

            Assert.AreEqual(195, totalPrice);
        }

        [Test]
        public void ComputePrice_Returns_The_Correct_Total_Price_With_Multiple_Offers()
        {
            var totalPrice = CheckoutSolution.ComputePrice("A,A,A,A,A,A,A,A,B,B,C,D");

            Assert.AreEqual(440, totalPrice);
        }

        [Test]
        public void ComputePrice_Returns_Minus_1_When_The_Given_Input_Is_Incorrect()
        {
            var totalPrice = CheckoutSolution.ComputePrice("F,A,A,A,B,L,C,D");

            Assert.AreEqual(-1, totalPrice);
        }
    }
}



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

            Assert.AreEqual(410, totalPrice);
        }

        [Test]
        public void ComputePrice_Returns_Minus_1_When_The_Given_Input_Is_Incorrect()
        {
            var totalPrice = CheckoutSolution.ComputePrice("F1AA3LCD");

            Assert.AreEqual(-1, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_With_19_A_Items_And_Discounts_Applied()
        {
            var totalPrice = CheckoutSolution.Checkout("AAAAAAAAAAAAAAAAAAA");

            Assert.AreEqual(780, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_One_B_FreeItem()
        {
            var totalPrice = CheckoutSolution.Checkout("AAAAAAAABEE");

            Assert.AreEqual(410, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_One_B_FreeItem_And_One_B_Full_Price()
        {
            var totalPrice = CheckoutSolution.Checkout("AAAAAAAABBEE");

            Assert.AreEqual(440, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_With_2_F()
        {
            var totalPrice = CheckoutSolution.Checkout("FF");

            Assert.AreEqual(20, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_With_3_F_Item_Including_1_Free()
        {
            var totalPrice = CheckoutSolution.Checkout("FFF");

            Assert.AreEqual(20, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_With_4_F_Item_Including_1_Free()
        {
            var totalPrice = CheckoutSolution.Checkout("FFFF");

            Assert.AreEqual(30, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_With_6_F_Item_Including_2_Free()
        {
            var totalPrice = CheckoutSolution.Checkout("FFFFFF");

            Assert.AreEqual(40, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_With_3_F_Item_Including_1_Free_And_One_Discount()
        {
            var totalPrice = CheckoutSolution.Checkout("FFFAAA");

            Assert.AreEqual(150, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_Any_3_Item_Of_Group_One_For_45()
        {
            var totalPrice = CheckoutSolution.Checkout("XYZ");

            Assert.AreEqual(45, totalPrice);
        }

        [Test]
        public void Checkout_Returns_The_Correct_Total_Price_Any_3_Item_Of_Group_One_For_45_And_One_Full_Price()
        {
            var totalPrice = CheckoutSolution.Checkout("XYZS");

            Assert.AreEqual(62, totalPrice);
        }
    }
}


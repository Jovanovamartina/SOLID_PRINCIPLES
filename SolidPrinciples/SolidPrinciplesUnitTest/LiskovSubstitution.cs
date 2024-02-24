using SolidPrinciples.LiskovSubstitution;


namespace SolidPrinciplesUnitTest
{
    [TestClass]
    public class LiskovSubstitution
    {
        [TestMethod]
        public void Apple_GetColor_ReturnsRed()
        {
            // Arrange
            Apple apple = new Apple();

            // Act
            string color = apple.GetColor();

            // Assert
            Assert.AreEqual("Red", color);
        }

        [TestMethod]
        public void Orange_GetColor_ReturnsOrange()
        {
            // Arrange
            Orange orange = new Orange();

            // Act
            string color = orange.GetColor();

            // Assert
            Assert.AreEqual("Orange", color);
        }

        [TestMethod]
        public void Orange_UsedAsApple_GetColor_ReturnsOrange()
        {
            // Arrange
            Apple apple = new Orange();

            // Act
            string color = apple.GetColor();

            // Assert
            Assert.AreEqual("Orange", color);
        }
    }

}

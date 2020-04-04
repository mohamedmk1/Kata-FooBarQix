using Kata2Solution;
using NUnit.Framework;

namespace NUnitTestKata2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_return_number()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "4";

            // Act
            string result = fbq.GetNumber(4);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_Foo_if_number_divisible_by_3()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "Foo";

            // Act
            string result = fbq.GetNumber(9);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_Bar_if_number_divisible_by_5()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "Bar";

            // Act
            string result = fbq.GetNumber(10);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_Qix_if_number_divisible_by_7()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "Qix";

            // Act
            string result = fbq.GetNumber(14);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_FooFoo_when_number_is_3()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "FooFoo";

            // Act
            string result = fbq.GetNumber(3);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_BarBar_when_number_is_5()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "BarBar";

            // Act
            string result = fbq.GetNumber(5);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_QixQix_when_number_is_7()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "QixQix";

            // Act
            string result = fbq.GetNumber(7);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_FooBar_when_number_is_51()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "FooBar";

            // Act
            string result = fbq.GetNumber(51);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_FooBar_when_number_is_53()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "BarFoo";

            // Act
            string result = fbq.GetNumber(53);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_FooQix_when_number_is_21()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "FooQix";

            // Act
            string result = fbq.GetNumber(21);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_Foo_when_number_is_13()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "Foo";

            // Act
            string result = fbq.GetNumber(13);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_Foo_when_number_is_15()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "FooBarBar";

            // Act
            string result = fbq.GetNumber(15);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void Should_return_FooFooFoo_when_number_is_33()
        {
            // Arrange
            FizzBuzzQix fbq = new FizzBuzzQix();
            string expectedResult = "FooFooFoo";

            // Act
            string result = fbq.GetNumber(33);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
using System;
using ComputerManagerTests.Parts.Rams.TestObject;
using NUnit.Framework;

namespace ComputerManagerTests.Parts.Rams
{
    public class RandomAccessMemoryTests
    {
        [Test]
        public void Ctor_PositiveMemorySize_ExpectObjectToBeCorrectlyInitialized()
        {
            //Arrange
            RandomAccessMemoryImpl ram;

            //Act
            ram = new(12);

            //Assert
            Assert.That(ram.GetMemorySize(), Is.EqualTo(12));
        }

        [Test]
        public void Ctor_ZeroMemorySize_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateRandomAccesMemoryWithNegativeMemorySize()
            {
                new RandomAccessMemoryImpl(0);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateRandomAccesMemoryWithNegativeMemorySize);
        }

        [Test]
        public void Ctor_NegativeMemorySize_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateRandomAccesMemoryWithNegativeMemorySize()
            {
                new RandomAccessMemoryImpl(-12);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateRandomAccesMemoryWithNegativeMemorySize);
        }
    }
}

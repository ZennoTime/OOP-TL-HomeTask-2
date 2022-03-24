using System;
using ComputerManager.Parts.Rams;
using NUnit.Framework;

namespace ComputerManagerTests.Parts.Rams
{
    class HyperX
    {
        [Test]
        public void DefaultCtor_ExpectObjectToBeInitializedCorrectly()
        {
            //Arrange
            HyperX ram;

            //Act
            ram = new HyperX();

            //Assert
            Assert.That(ram.GetMemorySize(), Is.EqualTo(12));
        }

        [Test]
        public void GetInfo_ReturnsExpectedMessage()
        {
            //Arrange
            string _expectedMessage = @$"
            ////////////////////////////////{Environment.NewLine}
            HYPERX IS THE BEST COMPANY
            {Environment.NewLine}Memory size: 12{Environment.NewLine}
            ////////////////////////////////";
            HyperX ram = new();

            //Act
            string info = ram.GetInfo();

            //Assert
            Assert.That(info, Is.EqualTo(_expectedMessage));
        }
    }
}


using System;
using ComputerManager.Parts.Rams;
using NUnit.Framework;

namespace ComputerManagerTests.Parts.Rams
{

    public class KingstonRx8Tests
    {
        [Test]
        public void DefaultCtor_ExpectObjectToBeInitializedCorrectly()
        {
            //Arrange
            KingstonRx8 ram;

            //Act
            ram = new KingstonRx8();

            //Assert
            Assert.That(ram.GetMemorySize(), Is.EqualTo(12));
        }

        [Test]
        public void GetInfo_ReturnsExpectedMessage()
        {
            //Arrange
            string _expectedMessage = @$"
////////////////////////////////{Environment.NewLine}
KINGSTON IS THE BEST COMPANY
{Environment.NewLine}Memory size: 12{Environment.NewLine}
////////////////////////////////";
            KingstonRx8 ram = new();

            //Act
            string info = ram.GetInfo();

            //Assert
            Assert.That(info, Is.EqualTo(_expectedMessage));
        }
    }
}

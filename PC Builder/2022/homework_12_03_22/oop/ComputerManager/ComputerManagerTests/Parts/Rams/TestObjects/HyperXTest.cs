using ComputerManager.Parts.Rams;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManagerTests.Parts.Rams.TestObjects
{
    class HyperXTest
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
KINGSTON IS THE BEST COMPANY 
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


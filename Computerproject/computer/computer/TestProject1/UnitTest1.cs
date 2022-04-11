using System;
using NUnit.Framework;
using computer.Parts.Rams;
using ñomputer.Parts.Processors;
using computer.Parts.GraphicalCards;
using Parts.MotherBoards;

namespace computerPartsTest
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

    public class AMDRyzenThreadripperPRO3995tests
    {
        [Test]
        public void DefaultCtor_ExpectObjectToBeInitializedCorrectly()
        {
            //Arrange
            AMDRyzenThreadripperPRO3995 processor;

            //Act
            processor = new AMDRyzenThreadripperPRO3995();

            //Assert
            Assert.That(processor.GetCountCores(), Is.EqualTo(9));
        }

        [Test]
        public void GetInfo_ReturnsExpectedMessage()
        {
            //Arrange
            string _expectedMessage = @$"
////////////////////////////////{Environment.NewLine}
PROCESSOR
{Environment.NewLine}Counts of cores: 9{Environment.NewLine}
////////////////////////////////";
            AMDRyzenThreadripperPRO3995 processor = new();

            //Act
            string info = processor.GetInfo();

            //Assert
            Assert.That(info, Is.EqualTo(_expectedMessage));
        }
    }

    public class Supermicrotests
    {
        [Test]
        public void DefaultCtor_ExpectObjectToBeInitializedCorrectly()
        {
            //Arrange
            Supermicro MotherBoard;

            //Act
            MotherBoard = new Supermicro();

            //Assert
            Assert.That(MotherBoard.GetAmountOfSocket(), Is.EqualTo(6));
        }

        [Test]
        public void GetInfo_ReturnsExpectedMessage()
        {
            //Arrange
            string _expectedMessage = @$"
////////////////////////////////{Environment.NewLine}
MOTHERBOARD 
{Environment.NewLine}Amount of sockets: 6{Environment.NewLine}
////////////////////////////////";
            Supermicro MotherBoard = new();

            //Act
            string info = MotherBoard.GetInfo();

            //Assert
            Assert.That(info, Is.EqualTo(_expectedMessage));
        }
    }

    public class PalitGeForceRTX3090Tests
    {
        [Test]
        public void DefaultCtor_ExpectObjectToBeInitializedCorrectly()
        {
            //Arrange
            PalitGeForceRTX3090 GraphicalCard;

            //Act
            GraphicalCard = new PalitGeForceRTX3090();

            //Assert
            Assert.That(GraphicalCard.GetMemorySize(), Is.EqualTo(6));
        }

        [Test]
        public void GetInfo_ReturnsExpectedMessage()
        {
            //Arrange
            string _expectedMessage = @$"
////////////////////////////////{Environment.NewLine}
BEST VIDEOCARD FOR GAMING
{Environment.NewLine}Memory size: 6GB{Environment.NewLine}
////////////////////////////////";
            PalitGeForceRTX3090 GraphicalCard = new();

            //Act
            string info = GraphicalCard.GetInfo();

            //Assert
            Assert.That(info, Is.EqualTo(_expectedMessage));
        }
    }
}
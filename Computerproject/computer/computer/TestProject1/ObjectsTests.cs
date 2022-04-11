using System;
using TestObject;
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

    public class ProcessorTests
    {
        [Test]
        public void Ctor_PositiveMountOfCoresSize_ExpectObjectToBeCorrectlyInitialized()
        {
            //Arrange
            ProcessorImpl processor;

            //Act
            processor = new(9);

            //Assert
            Assert.That(processor.GetCountCores(), Is.EqualTo(9));
        }

        [Test]
        public void Ctor_ZeroMountOfCores_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateMountOfCores()
            {
                new ProcessorImpl(0);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateMountOfCores);
        }

        [Test]
        public void Ctor_NegativeMountOfCores_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateWithNegativeMountOfCores()
            {
                new ProcessorImpl(-12);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateWithNegativeMountOfCores);
        }
    }

    public class MotherBoardTests
    {
        [Test]
        public void Ctor_PositiveMountOfSocket_ExpectObjectToBeCorrectlyInitialized()
        {
            //Arrange
            MotherBoardImpl motherBoard;

            //Act
            motherBoard = new(9);

            //Assert
            Assert.That(motherBoard.GetAmountOfSocket(), Is.EqualTo(9));
        }

        [Test]
        public void Ctor_ZeroMountOfSocket_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateMountOfSocket()
            {
                new MotherBoardImpl(0);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateMountOfSocket);
        }

        [Test]
        public void Ctor_NegativeMountOfSocket_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateWithNegativeMountOfSocket()
            {
                new MotherBoardImpl(-12);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateWithNegativeMountOfSocket);
        }
    }

    public class GraphicalCardTests
    {
        [Test]
        public void Ctor_PositiveMountOfMemory_ExpectObjectToBeCorrectlyInitialized()
        {
            //Arrange
            GraphicCardImpl graphicCard;

            //Act
            graphicCard = new(9);

            //Assert
            Assert.That(graphicCard.GetMemorySize(), Is.EqualTo(9));
        }

        [Test]
        public void Ctor_ZeroMountOfMemory_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateMountOfMemory()
            {
                new GraphicCardImpl(0);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateMountOfMemory);
        }

        [Test]
        public void Ctor_NegativeMountOfMemory_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            static void CreateWithNegativeMountOfMemory()
            {
                new GraphicCardImpl(-12);
            }

            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(CreateWithNegativeMountOfMemory);
        }
    }
}

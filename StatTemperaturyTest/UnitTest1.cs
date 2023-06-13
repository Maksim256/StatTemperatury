using StatTemperatury;

namespace StatTemperaturyTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void Statistics_SholdRetunMin()
        {
            //arrange
            var temperatura = new TemperaturyInFile("15", "45");
            temperatura.AddTemp("23,1");
            temperatura.AddTemp("21,2");
            temperatura.AddTemp("22,6");
            //act
             var statistics = temperatura.GetStatistics();

            //assert
            Assert.AreEqual(21.2, statistics.Min);


        }


        [Test]
        public void Statistics_SholdRetunMax()
        {
            //arrange
            var temperatura = new TemperaturyInFile("15", "45");
            temperatura.AddTemp("23,1");
            temperatura.AddTemp("21,2");
            temperatura.AddTemp("22,6");
            //act
            var statistics = temperatura.GetStatistics();

            //assert

            Assert.AreEqual(23.1, statistics.Max);
        }

        [Test]
        public void Statistics_SholdRetunAvg()
        {
            //arrange
            var temperatura = new TemperaturyInFile("15", "45");
            temperatura.AddTemp("23,1");
            temperatura.AddTemp("21,2");
            temperatura.AddTemp("22,6");
            //act
            var statistics = temperatura.GetStatistics();

            //assert

            Assert.AreEqual(22.3, statistics.average);
        }
    }
}
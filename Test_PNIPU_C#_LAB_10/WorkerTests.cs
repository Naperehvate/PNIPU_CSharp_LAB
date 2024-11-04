using ClassLibrary;

namespace Test_PNIPU_C__LAB_10
{
    public class WorkerTests
    {
        [SetUp]
        public void Setup()
        { }

        [Test]
        public void Worker_Init_ShouldSetPropertiesCorrectly()
        {
            var worker = new Worker();
            worker.RandomInit();

            Assert.IsNotNull(worker.Name, "Name should be initialized");
            Assert.That(worker.Age, Is.InRange(18, 65), "Age should be within working age range");
            Assert.IsNotNull(worker.Position, "Position should be initialized");
        }

        [Test]
        public void Worker_RandomInit_ShouldGenerateRandomValues()
        {
            var worker = new Worker();
            worker.RandomInit();

            Assert.IsNotNull(worker.Name, "Name should be set");
            Assert.That(worker.Age, Is.InRange(18, 65), "Age should be within working age range");
            Assert.IsNotNull(worker.Position, "Position should be set");
        }
    }
}
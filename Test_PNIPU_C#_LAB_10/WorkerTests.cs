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

            Assert.IsNotNull(worker.Name, "»м€ должно быть инициализировано");
            Assert.That(worker.Age, Is.InRange(18, 65), "¬озраст должен быть в пределах трудоспособного возраста");
            Assert.IsNotNull(worker.Position, "ѕозици€ должна быть инициализирована");
        }

        [Test]
        public void Worker_RandomInit_ShouldGenerateRandomValues()
        {
            var worker = new Worker();
            worker.RandomInit();

            Assert.IsNotNull(worker.Name, "»м€ должно быть задано");
            Assert.That(worker.Age, Is.InRange(18, 65), "¬озраст должен быть в пределах трудоспособного возраста");
            Assert.IsNotNull(worker.Position, "ѕоложение должно быть задано");
        }
    }
}
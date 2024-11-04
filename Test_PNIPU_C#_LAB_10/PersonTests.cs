using ClassLibrary;

namespace Test_PNIPU_C__LAB_10
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        { }

        [Test]
        public void Person_Init_ShouldSetPropertiesCorrectly()
        {
            var person = new Person();
            person.RandomInit();

            Assert.IsNotNull(person.Name, "Name should be initialized");
            Assert.That(person.Age, Is.InRange(0, 120)); // Проверка, что возраст находится в разумном диапазоне
        }

        [Test]
        public void Worker_RandomInit_ShouldGenerateRandomValues()
        {
            var worker = new Worker();
            worker.RandomInit();

            Assert.IsNotNull(worker.Name, "Name should be set");
            Assert.That(worker.Age, Is.InRange(18, 65)); // Рабочий возраст
            Assert.IsNotNull(worker.Position, "Position should be set");
        }
    }
}
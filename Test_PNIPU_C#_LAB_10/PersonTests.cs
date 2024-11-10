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

            Assert.IsNotNull(person.Name, "Имя должно быть инициализировано");
            Assert.That(person.Age, Is.InRange(0, 120)); 
        }

        [Test]
        public void Worker_RandomInit_ShouldGenerateRandomValues()
        {
            var worker = new Worker();
            worker.RandomInit();

            Assert.IsNotNull(worker.Name, "Имя должно быть задано");
            Assert.That(worker.Age, Is.InRange(18, 65)); 
            Assert.IsNotNull(worker.Position, "Положение должно быть задано");
        }
    }
}
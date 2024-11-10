using ClassLibrary;

namespace Test_PNIPU_C__LAB_10
{
    public class EngineerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Engineer_Init_ShouldSetPropertiesCorrectly()
        {
            var engineer = new Engineer();
            engineer.RandomInit();

            Assert.IsNotNull(engineer.Name, "Имя должно быть инициализировано");
            Assert.That(engineer.Age, Is.InRange(18, 65), "Возраст должен быть в пределах трудоспособного возраста");
            Assert.IsNotNull(engineer.Specialty, "Специализация должна быть инициализирована");
        }

        [Test]
        public void Engineer_RandomInit_ShouldGenerateRandomValues()
        {
            var engineer = new Engineer();
            engineer.RandomInit();

            Assert.IsNotNull(engineer.Name, "Имя должно быть задано");
            Assert.That(engineer.Age, Is.InRange(18, 65), "Возраст должен быть в пределах трудоспособного возраста");
            Assert.IsNotNull(engineer.Specialty, "Необходимо указать специализацию");
        }
    }
}
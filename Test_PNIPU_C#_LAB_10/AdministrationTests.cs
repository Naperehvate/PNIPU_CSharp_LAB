using ClassLibrary;

namespace Test_PNIPU_C__LAB_10
{
    public class AdministrationTests
    {
        [SetUp]
        public void Setup()
        { }

        [Test]
        public void Administration_Init_ShouldSetPropertiesCorrectly()
        {
            var admin = new Administration();
            admin.RandomInit();

            Assert.IsNotNull(admin.Name, "Имя должно быть инициализировано");
            Assert.That(admin.Age, Is.InRange(18, 65), "Возраст должен быть в пределах трудоспособного возраста");
            Assert.IsNotNull(admin.Department, "Отдел должен быть инициализирован");
        }

        [Test]
        public void Administration_RandomInit_ShouldGenerateRandomValues()
        {
            var admin = new Administration();
            admin.RandomInit();

            Assert.IsNotNull(admin.Name, "Имя должно быть задано");
            Assert.That(admin.Age, Is.InRange(18, 65), "Возраст должен быть в пределах трудоспособного возраста");
            Assert.IsNotNull(admin.Department, "Отдел должен быть установлен");
        }
    }
}
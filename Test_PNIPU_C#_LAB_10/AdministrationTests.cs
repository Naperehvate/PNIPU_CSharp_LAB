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

            Assert.IsNotNull(admin.Name, "Name should be initialized");
            Assert.That(admin.Age, Is.InRange(18, 65), "Age should be within working age range");
            Assert.IsNotNull(admin.Department, "Department should be initialized");
        }

        [Test]
        public void Administration_RandomInit_ShouldGenerateRandomValues()
        {
            var admin = new Administration();
            admin.RandomInit();

            Assert.IsNotNull(admin.Name, "Name should be set");
            Assert.That(admin.Age, Is.InRange(18, 65), "Age should be within working age range");
            Assert.IsNotNull(admin.Department, "Department should be set");
        }
    }
}
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

            Assert.IsNotNull(engineer.Name, "Name should be initialized");
            Assert.That(engineer.Age, Is.InRange(18, 65), "Age should be within working age range");
            Assert.IsNotNull(engineer.Specialty, "Specialization should be initialized");
        }

        [Test]
        public void Engineer_RandomInit_ShouldGenerateRandomValues()
        {
            var engineer = new Engineer();
            engineer.RandomInit();

            Assert.IsNotNull(engineer.Name, "Name should be set");
            Assert.That(engineer.Age, Is.InRange(18, 65), "Age should be within working age range");
            Assert.IsNotNull(engineer.Specialty, "Specialization should be set");
        }
    }
}
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

            Assert.IsNotNull(worker.Name, "��� ������ ���� ����������������");
            Assert.That(worker.Age, Is.InRange(18, 65), "������� ������ ���� � �������� ��������������� ��������");
            Assert.IsNotNull(worker.Position, "������� ������ ���� ����������������");
        }

        [Test]
        public void Worker_RandomInit_ShouldGenerateRandomValues()
        {
            var worker = new Worker();
            worker.RandomInit();

            Assert.IsNotNull(worker.Name, "��� ������ ���� ������");
            Assert.That(worker.Age, Is.InRange(18, 65), "������� ������ ���� � �������� ��������������� ��������");
            Assert.IsNotNull(worker.Position, "��������� ������ ���� ������");
        }
    }
}
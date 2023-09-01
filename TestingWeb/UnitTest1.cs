namespace TestingWeb
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Multiplicar()
        {
            WebTest.Logic logic = new WebTest.Logic();

            int result = logic.Multiplicar(5, 5);
            Assert.AreEqual(result, 20);
        }
    }
}
using DomainDrivenDesign.Dekra;

namespace DomainDrivenDesign.Dekra.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DekraAdaptor test = new DekraAdaptor(null);
            _ = test.GetDekraCalculationAsync("31626").GetAwaiter().GetResult();

            string test2 = "";

        }
    }
}
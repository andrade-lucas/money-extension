namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTest
{
    [TestMethod]
    public void should_convert_decimal_to_int()
    {
        decimal valor = 279.78M;
        var cents = valor.ToCents();

        Assert.AreEqual(27978, cents);
    }
}
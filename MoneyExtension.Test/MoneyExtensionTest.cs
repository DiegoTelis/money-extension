namespace MoneyExtension.Test;

[TestClass]
public class MoneyExtensionTest
{
    [TestMethod]
    public void ShouldConvertDecimaltoInt()
    {
        decimal valor = 279.45M;

        var cents = valor.ToCents();

        Assert.AreEqual(27945, cents);
    }
}
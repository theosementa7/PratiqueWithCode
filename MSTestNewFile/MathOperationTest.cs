using EvaluationSampleCode;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MSTestNewFile;

[TestClass]
public class MathOperationsTest
{

    private MathOperations _mathOperations;

    [TestMethod]
    [DataRow(8, 2, 10)]
    [DataRow(1, 7, 8)]
    public void Add_TwoNumbers_returnSum(int num1, int num2, int expectedResult)
    {
        var math = new MathOperations();
        var result = math.Add(num1, num2);

        Assert.AreEqual(result, expectedResult);
    }

    [TestMethod]
    [DataRow(8, 2, 4)]
    public void Test_Divide_TwoNumbers(int num1, int num2, int expectedResult)
    {
        var math = new MathOperations();
        var result = math.Divide(num1, num2);

        Assert.AreEqual(result, expectedResult);
    }

    [TestMethod]
    public void Test_Divide_TwoNumbers_returnExeption()
    {
        _mathOperations = new MathOperations();
        Assert.ThrowsException<ArgumentException>(() => _mathOperations.Divide(4, 0));
    }
}

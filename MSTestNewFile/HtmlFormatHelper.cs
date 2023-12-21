using EvaluationSampleCode;

namespace MSTestNewFile;

[TestClass]
public class HtmlFormatHelperTest
{
    [TestMethod]
    [DataRow("coucou")]
    [DataRow("hello")]
    [DataRow("hey")]
    public void Test_GetBoldFormat(string text)
    {
        var htmlFormatHelper = new HtmlFormatHelper();
        var result = htmlFormatHelper.GetBoldFormat(text);

        Assert.AreEqual(result, $"<b>{text}</b>");
    }

    [TestMethod]
    [DataRow("coucou")]
    [DataRow("hello")]
    public void Test_GetItalicFormat(string text)
    {
        var htmlFormatHelper = new HtmlFormatHelper();
        var result = htmlFormatHelper.GetItalicFormat(text);

        Assert.AreEqual(result, $"<i>{text}</i>");
    }

    [TestMethod]
    [DataRow("coucou", "hello")]
    public void Test_GetFormattedListElements(params string[] texts)
    {
        var htmlFormatHelper = new HtmlFormatHelper();
        var result = htmlFormatHelper.GetFormattedListElements(new List<string>(texts));

        Assert.AreEqual(result, "<ul><li>coucou</li><li>hello</li></ul>");
    }
}

using AngleSharp.Dom.Html;

namespace Html_Parser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}

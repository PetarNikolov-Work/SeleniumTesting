namespace Framework.Elements
{
    using Framework.Models;
    using System.Collections.Generic;
    public interface IElementFinder<T>
    {
        T FindElement(Locator locator);
        IEnumerable<T> FindElements(Locator locator);
    }
}

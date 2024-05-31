namespace Framework.Driver
{
    public interface IPageScroller
    {
        object ExecuteScrollingScript(string script, params object[] args);
    }
}

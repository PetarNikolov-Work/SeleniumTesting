namespace Framework.Driver
{
    public interface IPageNavigator
    {
        void NavigateToPage(string pageUrl);

        string GetCurrentUrl();
    }
}

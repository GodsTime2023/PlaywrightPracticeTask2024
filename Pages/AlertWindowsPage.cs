namespace PlaywrightPracticeTask2024.Pages
{
    public class AlertWindowsPage
    {
        private IPage _page;
        public AlertWindowsPage(IPage page)
        {
            _page = page;
        }

        ILocator browserWindow => _page.GetByText("Browser Windows");

        public async Task ClickBrowserWindow() => await browserWindow.ClickAsync();
        public async Task<string> VerifyAlertWindowPage() => await Task.FromResult(_page.Url);
    }
}

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
        ILocator alerts => _page.GetByText("Alerts");

        public async Task ClickBrowserWindow() => await browserWindow.ClickAsync();
        public async Task ClickAlerts() => await alerts.ClickAsync();
        public async Task<string> VerifyAlertWindowPage() => await Task.FromResult(_page.Url);

    }
}

namespace PlaywrightPracticeTask2024.Pages
{
    public class HomePage
    {
        private IPage _page;
        private readFromConfig _readFromConfig;
        public HomePage(IPage page)
        {
            _page = page;
            _readFromConfig = new readFromConfig();
        }

        ILocator elements => _page.GetByText("Elements");
        ILocator AlertFrameAndWindows => _page.GetByText("Alerts, Frame & Windows");

        public async Task GotoSite() => await _page.GotoAsync(_readFromConfig.GetJsonData("env:demoqaurl"));
        public async Task ClickElements()=> await elements.ClickAsync();
        public async Task ClickAlertFramesAndWindows()=> await AlertFrameAndWindows.ClickAsync();
    }
}
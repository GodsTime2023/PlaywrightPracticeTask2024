
namespace PlaywrightPracticeTask2024.Pages
{
    public class BrowserWindow
    {
        private IPage _page;
        public BrowserWindow(IPage page)
        {
            _page = page;
        }

        ILocator newTab => _page.GetByText("New Tab");
        ILocator newWindow => _page.Locator("#windowButton");

        public async Task ClickNewTab() => await newTab.ClickAsync();
        public async Task ClickNewWindowButton() => await newWindow.ClickAsync();

        public async Task<IPage> SwitchTab1()
        {
            Task.Delay(1000).Wait();
            var tabs = _page.Context.Pages; //Verify how many opened tabs
            _page = tabs[1]; //Switch to tab 1
            return _page;
        }

        public async Task<IPage> SwitchToTab0()
        {
            Task.Delay(1000).Wait();
            var tabs = _page.Context.Pages; //Verify how many opened tabs
            _page = tabs[0]; //Switch to tab 0
            return _page;
        }

        public async Task<string> VerifyNewTabWindow()
        {
            return await Task.FromResult(_page.Url);
        }

        public async Task<string> VerifyNewTabHeaderText()
        {
            var headerText = await _page.Locator("//h1").TextContentAsync();
            return await Task.FromResult(headerText);
        }
    }
}

using NUnit.Framework;

namespace PlaywrightPracticeTask2024.StepDefinitions
{
    [Binding]
    public class BrowserWindowsStepDefinitions
    {
        private BrowserWindow browserWindow;
        private AlertWindowsPage alertWindowsPage;
        private Task<IPage> page;
        public BrowserWindowsStepDefinitions(IObjectContainer container)
        {
            browserWindow = container.Resolve<BrowserWindow>();
            alertWindowsPage = container.Resolve<AlertWindowsPage>();
        }

        [Then(@"I am on browser windows new tab page")]
        public async Task ThenIAmOnBrowserWindowsPage()
        {
            var url = await browserWindow.VerifyNewTabWindow();
            Assert.That(url.Contains("sample"), Is.EqualTo(true));
        }

        [Then(@"I am on alert windows page")]
        public async Task ThenIAmOnAlertWindowsPage()
        {
            var url = await alertWindowsPage.VerifyAlertWindowPage();
            Assert.That(url.Contains("alertsWindows"), Is.EqualTo(true));
        }

        [When(@"I click New Tab button")]
        public async Task WhenIClcikNewTabButton()
        {
            await browserWindow.ClickNewTab();
        }

        [When(@"I click New Window button")]
        public async Task WhenIClcikNewWindowButton()
        {
            await Task.Delay(500);
            await browserWindow.ClickNewWindowButton();
        }

        [When(@"I switch to the new tab")]
        public async Task WhenISwitchToTheNewTab()
        {
            Task<IPage> page2 = browserWindow.SwitchTab1();
            page = page2;
            await Task.Delay(100);
        }

        [Then(@"'([^']*)' is displayed on tab page 2")]
        public async Task ThenIsDisplayedOnTabPage(string expectedHeaderText)
        {
            var actualHeaderText = await browserWindow.VerifyNewTabHeaderText();
            Assert.That(actualHeaderText == expectedHeaderText, Is.EqualTo(true));
        }

        [When(@"I switch to the new window")]
        public async Task WhenISwitchToTheNewWindow()
        {
            Task<IPage> page2 = browserWindow.SwitchTab1();
            page = page2;
            await Task.Delay(100);
        }

        [Then(@"'([^']*)' is displayed on window page 2")]
        public async Task ThenIsDisplayedOnWindowPage(string expectedHeaderText)
        {
            var actualHeaderText = await browserWindow.VerifyNewTabHeaderText();
            Assert.That(actualHeaderText == expectedHeaderText, Is.EqualTo(true));
        }

        [Then(@"I am on browser windows new window page")]
        public async Task ThenIAmOnBrowserWindowsNewWindowPage()
        {
            var url = await browserWindow.VerifyNewTabWindow();
            Assert.That(url.Contains("sample"), Is.EqualTo(true));
        }
    }
}
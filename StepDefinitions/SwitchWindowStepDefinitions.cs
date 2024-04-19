namespace PlaywrightPracticeTask2024.StepDefinitions
{
    [Binding]
    public class SwitchWindowStepDefinitions
    {
        private AlertWindowsPage alertWindowsPage;
        public SwitchWindowStepDefinitions(IObjectContainer container)
        {
            alertWindowsPage = container.Resolve<AlertWindowsPage>();
        }

        [When(@"I click Browser windows")]
        public async Task WhenIClickBrowserWindows()
        {
            await alertWindowsPage.ClickBrowserWindow();
        }
    }
}
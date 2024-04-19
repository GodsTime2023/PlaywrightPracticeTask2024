namespace PlaywrightPracticeTask2024.StepDefinitions;

[Binding]
public sealed class DemoqaHomePageStepDefinitions
{
    private HomePage homePage;
    public DemoqaHomePageStepDefinitions(IObjectContainer container)
    {
        homePage = container.Resolve<HomePage>();
    }

    [Given(@"user is on demoqa page")]
    public async Task GivenUserIsOnDemoqaPage()
    {
        await homePage.GotoSite();
    }

    [When(@"user click on Elements")]
    public async Task WhenUserClickOnElements()
    {
        await homePage.ClickElements();
    }

    [When(@"user click on Alerts, Frame & Windows")]
    public async Task WhenUserClickOnAlertsFrameWindows()
    {
        await homePage.ClickAlertFramesAndWindows();
    }
}
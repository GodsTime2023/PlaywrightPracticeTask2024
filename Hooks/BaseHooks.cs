namespace PlaywrightPracticeTask2024.Hooks;

[Binding]
public class BaseHooks : DriverContext
{
    private IObjectContainer _container;
    public BaseHooks(IObjectContainer container)
    {
        _container = container;
    }

    [BeforeScenario]
    public async Task BeforeScenario()
    {
        await CreateSession();
        _container.RegisterInstanceAs(_page);
    }

    [AfterScenario]
    public async Task CloseBrowser()
    {
        await QuitBrowser();
    }
}

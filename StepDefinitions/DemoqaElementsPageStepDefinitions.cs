namespace PlaywrightPracticeTask2024.StepDefinitions;

[Binding]
public class DemoqaElementsPageStepDefinitions
{
    private ElementsPage _elementsPage;
    public DemoqaElementsPageStepDefinitions(IObjectContainer container)
    {
        _elementsPage = container.Resolve<ElementsPage>();
    }

    [When(@"user click Text Box menu")]
    public async Task WhenUserClickTextBoxMenu()
    {
        await _elementsPage.ClickTextBox();
    }
}

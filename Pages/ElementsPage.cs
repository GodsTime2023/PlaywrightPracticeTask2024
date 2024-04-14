namespace PlaywrightPracticeTask2024.Pages;

public class ElementsPage
{
    private IPage _page;
    public ElementsPage(IPage page) => _page = page;

    ILocator textBox => _page.GetByText("Text Box");


    public async Task ClickTextBox() => await textBox.ClickAsync();
}

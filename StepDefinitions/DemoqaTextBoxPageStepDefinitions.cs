namespace PlaywrightPracticeTask2024.StepDefinitions;

[Binding]
public class DemoqaTextBoxPageStepDefinitions
{
    private TextBoxPage _textBoxPage;
    public DemoqaTextBoxPageStepDefinitions(IObjectContainer container)
    {
        _textBoxPage = container.Resolve<TextBoxPage>();
    }

    [When(@"user enters the following details")]
    public async Task WhenUserEntersTheFollowingDetails(Table table)
    {
        var tableData = table.CreateInstance<TextBoxPageTableModel>();
        await _textBoxPage.CompleteForm(
            tableData.FullName,
            tableData.Email,
            tableData.CurrentAddress,
            tableData.ParmanentAddress);
    }

    [When(@"user click submit button")]
    public async Task WhenUserClickSubmitButton()
    {
        await _textBoxPage.ClickSubmitBtn();
    }

    [Then(@"the following details are displayed in output")]
    public async Task ThenTheFollowingDetailsAreDisplayedInOutput(Table table)
    {
        await Task.Delay(100);
        var expectedTableData = table.Rows.ToList().First().Values;
        var actualOutPutData = _textBoxPage.GetOutPutDatas().Result.ToList();
        //var data = await _textBoxPage.GetOutPutListDatas();
        expectedTableData
            .Should().BeEquivalentTo(actualOutPutData);
    }
}
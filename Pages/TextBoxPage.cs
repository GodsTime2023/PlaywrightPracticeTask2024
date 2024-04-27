namespace PlaywrightPracticeTask2024.Pages;

public class TextBoxPage
{
    private IPage _page;
    public TextBoxPage(IPage page) => _page = page;

    private ILocator fullName => _page.GetByPlaceholder("Full Name");
    private ILocator email => _page.GetByPlaceholder("name@example.com");
    private ILocator currentAddress => _page.GetByPlaceholder("Current Address");
    private ILocator parmanentAddress => _page.Locator("#permanentAddress");
    private ILocator submitBtn => _page.Locator("#submit");
    private Task<IReadOnlyList<IElementHandle>> output => _page.QuerySelectorAllAsync("#output > div > p");

    public async Task EnterFullName(string fname) => await fullName.FillAsync(fname);
    public async Task EnterEmail(string emailAddress) => await email.FillAsync(emailAddress);
    public async Task EnterCurrentAddress(string cAddress) => await currentAddress.FillAsync(cAddress);
    public async Task EnterParmanentAddress(string pAddress) => await parmanentAddress.FillAsync(pAddress);
    public async Task ClickSubmitBtn() => await submitBtn.ClickAsync();


    public async Task<List<string>> GetOutPutDatas() //This method is same as the one below
    {
        List<string> data = new List<string>();
        output.Result.ToList()
            .ForEach(x =>{
                data.Add(x.TextContentAsync()
                    .Result?.Split(":")[1].Trim()!); });

        return data;
    }

    public async Task<List<string>> GetOutPutListDatas() //This method is same as the one above
    {
        var data = await Task.WhenAll(output.Result.Select(async x =>
        {
            var splitResult = x.TextContentAsync().Result?.Split(":");
            return splitResult != null && splitResult.Length > 1
            ? splitResult[1].Trim() : null;
        }));

        return data.Where(x => x != null).ToList()!;
    }

    public async Task CompleteForm(string fulname, string email, 
        string caddress, string paddress)
    {
        await EnterFullName(fulname);
        await EnterEmail(email);
        await EnterCurrentAddress(caddress);
        await EnterParmanentAddress(paddress);
    }
}

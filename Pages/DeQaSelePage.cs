using PlaywrightPracticeTask2024.WaitHelpers;

namespace PlaywrightPracticeTask2024.Pages
{
    public class DeQaSelePage
    {
        private IPage _page;
        private readFromConfig _readFromConfig;
        public DeQaSelePage(IPage page)
        {
            _page = page;
            _readFromConfig = new readFromConfig();
        }

        ILocator Widgets => _page.GetByText("Widgets");
        ILocator selectMenu => _page.GetByText("Select Menu");
        ILocator selectOption => _page.Locator("#withOptGroup div").Filter(new() { HasText = "Select Option" }).Nth(1);
        ILocator selectValue => _page.GetByText("Group 2, option 1", new() { Exact = true });
        ILocator selectOne => _page.Locator("#selectOne div").Filter(new() { HasText = "Select Title" }).Nth(1);
        ILocator selectTitle => _page.GetByText("Prof.", new() { Exact = true });
        ILocator OldStyleDropdown => _page.Locator("#oldSelectMenu");
        ILocator multiColours => _page.Locator("#selectMenuContainer svg").Nth(2);
        ILocator multiColours1 => _page.Locator("#react-select-4-option-0");
        ILocator multiColours2 => _page.Locator("#react-select-4-option-2");
        ILocator standardCars => _page.Locator("#cars");
        
        public async Task<string> ValidateWidgetsPage()
        {
            return await Task.FromResult(_page.Url);
        }
        public async Task<string> ValidateSelectMenuPage()
        {
            return await Task.FromResult(_page.Url);
        }
        public async Task GotoSite() => await _page.GotoAsync(
                _readFromConfig.GetJsonData("env:demoqaurl"));

        public async Task ClickWidgets()
        {
        await Widgets.ClickAsync();
        await Task.Delay(3000);
        }
        public async Task ClickSelectMenu()
        {
            await selectMenu.ClickAsync();
            await Task.Delay(3000);
        }
        public async Task ClickSelectOption()
        {
            await selectOption.ClickAsync();
            await Task.Delay(3000);

            await selectValue.ClickAsync();
        await Task.Delay(2000);
        }
        public async Task ClickSelectOne()
        {
            await selectOne.ClickAsync();
            await Task.Delay(2000);

            await selectTitle.ClickAsync();
            await Task.Delay(2000);
        }
        public async Task SelectOldStyleColor(string color)
        {
            await OldStyleDropdown.SelectOptionAsync(color);
        }
        public async Task ClickMultiColours()
        {
            await multiColours.ClickAsync();
            await Task.Delay(2000);

            await multiColours1.ClickAsync();
            await multiColours2.ClickAsync();
            await Task.Delay(500);

        }
        public async Task ClickStandardCars()
        {
            await standardCars.SelectOptionAsync(new[] { "opel", "saab", "audi", "volvo" });
            await Task.Delay(3000);
        }
        public async Task<List<string>> GetSelectedOptions()
        {
            // Retrieve all selected options from the dropdown
            var selectedValues = await _page.EvalOnSelectorAsync<string[]>("#cars",
             "select => Array.from(select.selectedOptions).map(option => option.value)");

            return selectedValues.ToList();
        }
    }
}
   

  
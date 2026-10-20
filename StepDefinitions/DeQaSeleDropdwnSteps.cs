using Reqnroll;
using Reqnroll.BoDi;

namespace PlaywrightPracticeTask2024.StepDefinitions
{
    [Binding]
    public class DeQaSeleDropdwnSteps
    {
        private DeQaSelePage deQaSelePage;
        public DeQaSeleDropdwnSteps(IObjectContainer container)
        {
            deQaSelePage = container.Resolve<DeQaSelePage>();
        }
        [Given(@"I navigate to Demoqa website")]
        public async Task GivenINavigateToDemoqaWebsite()
        {
            await deQaSelePage.GotoSite();
        }

        [Then(@"I verify that home page is displayed successfully")]
        public async Task ThenIVerifyThatHomePageIsDisplayedSuccessfully()
        {

            var url = await deQaSelePage.ValidateWidgetsPage();
            Assert.That(url.Contains("demoqa"), Is.EqualTo(true));
        }

        [When(@"I click Widgets tab menu")]
        public async Task WhenIClickWidgetstabMenu()
        {
            await deQaSelePage.ClickWidgets();
        }

        [When(@"I validate the page is displayed")]
        public async Task WhenIValidateThePageIsDisplayed()
        {
            var url = await deQaSelePage.ValidateSelectMenuPage();
            Assert.That(url.Contains("demoqa"), Is.EqualTo(true));
        }

        [When(@"I click on select menu")]
        public async Task WhenIClickOnSelectMenu()
        {
            await deQaSelePage.ClickSelectMenu();
        }

        [When(@"I click on dropdown to Select group Option")]
        public async Task WhenIClickOnDropdownToSelectGroupOption()
        {
            await deQaSelePage.ClickSelectOption();
        }

        [When(@"I click on dropdown to Select the Title")]
        public async Task WhenIClickOnDropdownToSelectTheTitle()
        {
            await deQaSelePage.ClickSelectOne();
        }

        [When(@"I select a color from the dropdown labeled Old Style")]
        public async Task AndISelectAColorFromTheDropdownLabeledOldStyle()
        {
            await deQaSelePage.SelectOldStyleColor("Yellow");  
        }

        [When(@"I click on dropdown to Select Multi Colour")]
        public async Task WhenIClickOnDropdownToSelectMultiColour()
        {
            await deQaSelePage.ClickMultiColours();
        }

        [When(@"I click on dropdown to select multi standard")]
        public async Task WhenIClickOnDropdownToSelectMultiStandard(Table table)
        {
            await deQaSelePage.ClickStandardCars();
        }

        [Then(@"the selected menus should be validated")]
        public async Task ThenTheSelectedMenusShouldBeValidated()
        {
            // Validate the selected options
            var selectedOptions = await deQaSelePage.GetSelectedOptions();
            var expectedOptions = new List<string> { "opel", "saab", "audi", "volvo" };

            foreach (var option in expectedOptions)
            {
                if (!selectedOptions.Contains(option))
                {
                    throw new Exception($"Validation failed: {option} is not selected.");
                }
            }
            Console.WriteLine("Validation successful: All expected options are selected.");
            Console.WriteLine("Selected Options: " + string.Join(", ", selectedOptions));
        }
    }
}

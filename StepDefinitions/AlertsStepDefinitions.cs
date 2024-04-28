using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightPracticeTask2024.Pages;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace PlaywrightPracticeTask2024.StepDefinitions
{
    [Binding]
    public class AlertsStepDefinitions
    {
        private AlertsPage alertsPage;
        private IPage _page;
        public AlertsStepDefinitions(IObjectContainer container)
        {
            alertsPage = container.Resolve<AlertsPage>();
        }

        [Then(@"I click Alerts")]
        public async Task ThenIClickAlerts()
        {
            await alertsPage.ClickAlertsTab();
        }

        [Then(@"I click on the first Click me button")]
        public async Task ThenIClickOnTheFirstClickMeButton()
        {
             await alertsPage.ClickSeeAlert();
        }

        [Then(@"an alert message is displayed")]
        public async Task ThenAnAlertMessageIsDisplayed()
        {
           var isDisplayed =  await  alertsPage.SeeAlertMessageDisplayed();
            Assert.That(isDisplayed, Is.EqualTo(true));
        }

        [Then(@"I click on the second Click me button")]
        public async Task ThenIClickOnTheSecondClickMeButton()
        {
            await alertsPage.ClickNewWindowButton();
        }

        [Then(@"an Alert message will appear 5 second later")]
        public async Task ThenAnAlertMessageWillAppearSecondLater()
        {
            
        }

        [Then(@"I click on the third Click me button")]
        public async Task ThenIClickOnTheThirdClickMeButton()
        {
           await alertsPage.ClickConfirmBoxAlert();
        }

        [Then(@"I click on the OK or Cancel button")]
        public  void ThenIClickOnTheOKOrCancelButton()
        {
           
        }

        [Then(@"the following text is displayed in green:")]
        public void ThenTheFollowingTextIsDisplayedInGreen(Table table)
        {
            
        }


        [Then(@"I click on the fourth Click me button")]
        public async Task ThenIClickOnTheFourthClickMeButton()
        {
            await alertsPage.ClickPromptBoxAlert();
        }

        [Then(@"I enter the following word:")]
        public void ThenIEnterTheFollowingWord(Table table)
        {
           
        }

        [Then(@"I click ok button")]
        public void ThenIClickOkButton()
        {
           
        }

        [Then(@"the following word is displayed in green color:")]
        public void ThenTheFollowingWordIsDisplayedInGreenColor(Table table)
        {
           
        }
    }
}

using NUnit.Framework;
using System.Security.Cryptography;

namespace PlaywrightPracticeTask2024.Pages
{
    public class AlertsPage
    {
        private IPage _page;
        public AlertsPage(IPage page)
        {
            _page = page;
        }

        ILocator Alerts => _page.Locator("li").Filter(new() { HasText = "Alerts" });
                                   
        ILocator Clickme => _page.Locator("#alertButton");
        ILocator Clickme2 => _page.Locator("#timerAlertButton");
        ILocator Clickme3 => _page.Locator("#confirmButton");
        ILocator ConfirmResultDisplayed => _page.Locator("#confirmResult");
        ILocator Clickme4 => _page.Locator("#promtButton");


        public async Task ClickAlertsTab()
        {
            await Alerts.WaitForAsync();
            await Alerts.ClickAsync();
        }

        public async Task ClickSeeAlert() => await Clickme.ClickAsync();
        public async Task ClickNewWindowButton() => await Clickme2.ClickAsync();
        public async Task ClickConfirmBoxAlert() => await Clickme3.ClickAsync();
        public async Task ClickPromptBoxAlert() => await Clickme4.ClickAsync();

        public async Task<bool> SeeAlertMessageDisplayed()
        {
            _page.Dialog += async (_, dialog) =>
            {
                await dialog.AcceptAsync();
            };
           return await _page.GetByRole(AriaRole.Button).IsVisibleAsync();
        }

        public async Task ConfirmAlertMessageDisplayed()
        {
            _page.Dialog += async (_, dialog) =>
            {
                await dialog.AcceptAsync();
            };
            await _page.GetByRole(AriaRole.Button).ClickAsync();
        }
    }
}

namespace PlaywrightPracticeTask2024.Drivers;

public class DriverContext
{
    private IPlaywright _playwright;
    private IBrowser _browser;
    public IPage _page;

    public async Task<IPage> CreateSession()
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new()
        {
            Channel = "chrome",
            SlowMo = 50,
            Headless = false
        });

        _page = await _browser.NewPageAsync(new()
        {
             ViewportSize = 
             new ViewportSize()
             {Height = 610, Width = 1310}
        });
        //await _page.PauseAsync();
        return _page;
        
    }
    public async Task QuitBrowser() => await _page.CloseAsync();
}

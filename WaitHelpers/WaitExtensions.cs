namespace PlaywrightPracticeTask2024.WaitHelpers;

public static class WaitExtensions
{
    /// <summary>
    /// This method wait until element is displayed
    /// </summary>
    /// <param name="page"></param>
    /// <param name="locator"></param>
    /// <returns></returns>
    public static async Task<IElementHandle?> WaitForDisplayed(this IPage page, string locator)
    {
        return await page.WaitForSelectorAsync(locator, 
            new PageWaitForSelectorOptions { State = WaitForSelectorState.Visible});
    }

    /// <summary>
    /// Waits until element is displayed
    /// </summary>
    /// <param name="page"></param>
    /// <param name="locator"></param>
    /// <returns></returns>
    public static async Task<IElementHandle?> WaitForElementDisplayed(this ILocator page, string locator)
    {
        return await page.WaitForElementDisplayed(locator);
    }

    /// <summary>
    /// Waits for element and get text from a single element
    /// </summary>
    /// <param name="page"></param>
    /// <param name="locator"></param>
    /// <returns></returns>
    public static async Task<string?> WaitForElementAndGetText(this ILocator page, string locator)
    {
        var text = await page.WaitForElementDisplayed(locator).Result?.TextContentAsync()!;
        return text;
    }

    /// <summary>
    /// This methods gets all the text from a list
    /// </summary>
    /// <param name="locator"></param>
    /// <returns></returns>
    public static async Task<List<string?>> GetAllElementText(this Task<IReadOnlyList<IElementHandle>> locator)
    {
        List<string> data = new List<string>();
        locator.Result.ToList()
            .ForEach(x =>
            {
                data.Add(x.TextContentAsync()
                    .Result?.Split(":")[1].Trim()!);
            });
        await Task.Delay(100);
        return data.ToList()!;
    }

    /// <summary>
    /// Waits for single element and get text from a list
    /// </summary>
    /// <param name="ele"></param>
    /// <param name="locator"></param>
    /// <returns></returns>
    public static async Task<List<string?>> WaitAndGetAllText(
        this Task<IReadOnlyList<IElementHandle>> ele, string locator)
    {
        await ele.Result.First().WaitForSelectorAsync(locator,
            new ElementHandleWaitForSelectorOptions { State = WaitForSelectorState.Visible });
        List<string> data = new List<string>();
        ele.Result.ToList()
            .ForEach(x =>
            {
                data.Add(x.TextContentAsync()
                    .Result?.Split(":")[1].Trim()!);
            });
        await Task.Delay(100);
        return data.ToList()!;
    }
}

using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTestsDotNet;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExampleTest : PageTest
{
    IBrowser _browser;

    [SetUp]
    public void SetUp()
    {
        _browser = Playwright.Chromium.LaunchAsync(new() {
            Headless = false
        }).GetAwaiter().GetResult();
    }

    [TearDown]
    public void TearDown()
    {
        _browser.CloseAsync();
    }

    [Test]
    public async Task HasTitle()
    {
        var page = await _browser.NewPageAsync();
        await page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(page).ToHaveTitleAsync(new Regex("Playwright"));
    }

    [Test]
    public async Task GetStartedLink()
    {
        var page = await _browser.NewPageAsync();
        await page.GotoAsync("https://playwright.dev");

        // Click the get started link.
        await page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();

        // Expects page to have a heading with the name of Installation.
        await Expect(page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
        await Expect(page.Locator("//h2[@id='introduction']")).ToBeVisibleAsync();
    }
}
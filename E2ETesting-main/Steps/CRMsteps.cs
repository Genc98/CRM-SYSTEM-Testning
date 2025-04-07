namespace E2ETesting.Steps;

using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;


[Binding]
public class CRMsteps
{
    
    
    private IPlaywright _playwright;
    private IBrowser _browser;
    private IBrowserContext _context;
    private IPage _page;

    [BeforeScenario]
    public async Task Setup()
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new() { Headless = false, SlowMo = 500 });
        _context = await _browser.NewContextAsync();
        _page = await _context.NewPageAsync();
    }

    [AfterScenario]
    public async Task Teardown()
    {
        await _browser.CloseAsync();
        _playwright.Dispose();
    }
    
    // STEPS:


    [Given(@"I am on the CRM system startpage")]
    public async Task GivenIAmOnTheCrmSystemStartpage()
    {
        await _page.GotoAsync("http://localhost:4000/");
        // await _page.WaitForTimeoutAsync(3000);
    }
    
    [When(@"I enter my email")]
    public async Task WhenIEnterMyEmail()
    {
        await _page.FillAsync("input[name='email']", "gencgashi98@gmail.com");
    }
}
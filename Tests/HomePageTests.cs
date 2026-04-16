using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightTests.Pages;

namespace PlaywrightTests.Tests;

[TestFixture]
public class HomePageTests : PageTest
{
    [Test]
    public async Task OpenVoyagerPreprodHomePage()
    {
        var homePage = new HomePage(Page);

        await homePage.Navigate();

        await Page.WaitForTimeoutAsync(5000);

        Assert.That(await Page.TitleAsync(), Is.Not.Null.And.Not.Empty);
    }
}
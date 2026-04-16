using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightTests.Pages;

public class HomePage
{
    private readonly IPage _page;
    private const string Url = "https://voyagerpreprod.zesty.dev/";

    public HomePage(IPage page)
    {
        _page = page;
    }

    public async Task Navigate()
    {
        await _page.GotoAsync(Url);
    }
}
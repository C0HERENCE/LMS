using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LMS.Pages;

public class Index_Tests : LMSWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

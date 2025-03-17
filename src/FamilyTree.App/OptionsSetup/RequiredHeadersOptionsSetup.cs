using FamilyTree.Web.ConfigOptions;
using Microsoft.Extensions.Options;

namespace FamilyTree.App.OptionsSetup;

public class RequiredHeadersOptionsSetup : IConfigureOptions<RequiredHeaderConfig>
{
    private const string SectionName = "RequiredHeaders";
    private readonly IConfiguration _configuration;

    public RequiredHeadersOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(RequiredHeaderConfig options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}

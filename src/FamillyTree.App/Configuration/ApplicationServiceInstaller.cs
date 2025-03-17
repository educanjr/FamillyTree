using FamillyTree.App.OptionsSetup;

namespace FamillyTree.App.Configuration;

public class ApplicationServiceInstallerpublic : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureOptions<GameRullerOptionsSetup>();

        services.AddMediatR(mediatrService =>
        {
            mediatrService.RegisterServicesFromAssembly(Application.AssemblyReference.Assembly);
        });
    }
}

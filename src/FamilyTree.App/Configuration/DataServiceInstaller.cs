using FamilyTree.Data;
using Microsoft.EntityFrameworkCore;
using Scrutor;

namespace FamilyTree.App.Configuration;

public class DataServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.Scan(selector => selector
                .FromAssemblies(AssemblyReference.Assembly)
                .AddClasses(false)
                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                .AsMatchingInterface()
                .WithScopedLifetime());

        var dbSettings = new DbSettings(configuration.GetConnectionString("FamilyTreeDatabase"));
        services.AddSingleton<IDbSettings, DbSettings>((services) => dbSettings);

        services.AddDbContext<IFamilyTreeDbContext, FamilyTreeDbContext>(opt => opt.UseNpgsql(dbSettings.ConnectionString, sqlOpt =>
        {
            sqlOpt.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(10),
                errorCodesToAdd: null
            );
            sqlOpt.MigrationsAssembly("FamilyTree.Data");
        }));
    }
}

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FamillyTree.Data;

public class FamillyTreeDbContextFactory : IDesignTimeDbContextFactory<FamillyTreeDbContext>
{
    public FamillyTreeDbContext CreateDbContext(string[] args)
    {
        //Ensure the correct base directory
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../FamillyTree.App");

        var builder = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

        var config = builder
            .Build();
        var connectionString = config.GetConnectionString("FamillyTreeDatabase");
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Could not find the connection string. Check your appsettings.json.");
        }

        var optionsBuilder = new DbContextOptionsBuilder<FamillyTreeDbContext>();
        

        optionsBuilder.UseNpgsql(connectionString, sqlOpt =>
            sqlOpt.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorCodesToAdd: null));

        var dbSettings = new DbSettings(config.GetConnectionString("FamillyTreeDatabase"));
        return new FamillyTreeDbContext(optionsBuilder.Options, dbSettings);
    }
}

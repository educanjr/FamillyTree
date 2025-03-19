using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using FamilyTree.App.OptionsSetup;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FamilyTree.App.Configuration;

public class WebServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1);
                opt.ApiVersionReader = new UrlSegmentApiVersionReader();
            })
            .AddApiExplorer(opt =>
            {
                opt.GroupNameFormat = "'v'VVV"; //Formats versions as v1, v2, etc.
                opt.SubstituteApiVersionInUrl = true;
            });

        services.AddEndpointsApiExplorer();

        services
            .AddControllers()
            .AddApplicationPart(Web.AssemblyReference.Assembly);

        services.AddSwaggerGen(opt =>
        {
            var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();

            foreach (var description in provider.ApiVersionDescriptions)
            {
                opt.SwaggerDoc(description.GroupName, new OpenApiInfo
                {
                    Title = $"Family Tree API {description.ApiVersion}",
                    Version = description.ApiVersion.ToString()
                });
            }

            // Define x-client-id as a required header
            opt.AddSecurityDefinition("X-Client-Id", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Name = "x-client-id",
                Type = SecuritySchemeType.ApiKey,
                Description = "Custom client ID header required for API authentication"
            });

            opt.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "X-Client-Id"
                        }
                    },
                    new List<string>()
                }
            });
        });

        services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
                builder =>
                {
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
        });

        services.AddValidatorsFromAssembly(Web.AssemblyReference.Assembly);
        services.AddFluentValidationAutoValidation();

        services.ConfigureOptions<RequiredHeadersOptionsSetup>();
    }
}

//Custom classes for versioning
public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider;
    public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => _provider = provider;

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(description.GroupName, new OpenApiInfo
            {
                Title = $"Family Tree API {description.ApiVersion}",
                Version = description.ApiVersion.ToString()
            });
        }
    }
}

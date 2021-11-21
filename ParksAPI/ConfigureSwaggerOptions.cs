namespace ParksAPI
{
    using Microsoft.AspNetCore.Mvc.ApiExplorer;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
    using Microsoft.OpenApi.Models;
    using Swashbuckle.AspNetCore.SwaggerGen;
    using System;

    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
      readonly IApiVersionDescriptionProvider provider;

      public ConfigureSwaggerOptions( IApiVersionDescriptionProvider provider) => this.provider = provider;

      public void Configure( SwaggerGenOptions options)
      {
        foreach(var description in provider.ApiVersionDescriptions)
        {
          options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
        }
      }

      static OpenApiInfo CreateInfoForApiVersion( ApiVersionDescription description)
      {
        var info = new OpenApiInfo()
        {
          Title = "Parks API",
          Version = description.ApiVersion.ToString(),
          Description = "An API for the expectant explorer of parks",
          Contact = new OpenApiContact() { Name = "Tim Roth", Email = "timdroth@gmail.com"},
          License = new OpenApiLicense() { Name = "MIT", Url = new Uri( "https://opensource.org/licenses/MIT" )}
        };

        if(description.IsDeprecated)
        {
          info.Description += " This API version has been deprecated";
        }

        return info;
      }
    }
}
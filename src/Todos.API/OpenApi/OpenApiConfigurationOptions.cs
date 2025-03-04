﻿using System;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;

namespace Todos.API.OpenApi;
internal class OpenApiConfigurationOptions : IOpenApiConfigurationOptions
{
    public OpenApiInfo Info { get; set; } = new()
    {
        Version = "1.0.0",
        Title = "Todos on Azure - Azure Function + Table Storage",
        Description = "Azure Function with Table Storage for Persisting Todos",
        Contact = new OpenApiContact
        {
            Name = "Marcel Michau",
            Url = new Uri("https://github.com/MarcelMichau/todos-on-azure-functions-table-storage"),
        },
        License = new OpenApiLicense
        {
            Name = "MIT",
            Url = new Uri("http://opensource.org/licenses/MIT"),
        }
    };

    public List<OpenApiServer> Servers { get; set; } = new();
    public OpenApiVersionType OpenApiVersion { get; set; } = OpenApiVersionType.V3;
    public bool IncludeRequestingHostName { get; set; }
    public bool ForceHttp { get; set; } = false;
    public bool ForceHttps { get; set; } = false;
    public List<IDocumentFilter> DocumentFilters { get; set; } = new();
}

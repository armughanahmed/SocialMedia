using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using SocialMedia.Api.Extensions;
using SocialMedia.Api.Options;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices(typeof(Program));

var app = builder.Build();

app.RegisterPipelineComponents(typeof(Program));

app.Run();

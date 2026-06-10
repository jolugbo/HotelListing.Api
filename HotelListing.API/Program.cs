var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//1.structure justification and how to ensure good  organisation
//2. explain environment configuration and how it supports different deployment scenarios.
//3. Dependency injection and how it supports loose coupling and testability.
//4. address potential concerns about misconfigurations or long term maintainability.


//You should clarify how your environment-specific logging settings fit into a broader
//deployment configuration strategy, and distinguish local launch settings from production
//settings to make your deployment story stronger.

//Explain that launchSettings.json is mainly for local development,
//then describe how appsettings.json, environment-specific appsettings files,
//and environment variables support staging and production.
//Also mention how sensitive values should be handled separately from source-controlled files.


//You referenced the Program.cs builder and framework logging capabilities,
//but you did not clearly explain your dependency registrations or how they follow
//best practices such as constructor injection.
//You should be more specific about which services you register in Program.cs
//and how you use constructor injection so your dependency injection approach is clearer and closer to best practice.
//Name the kinds of services you plan to register in Program.cs,
//explain why constructor injection is preferred, and show how DI keeps
//dependencies loosely coupled and easier to test.

//You should explain how your logging service will be used to detect and respond to
//configuration problems, and mention what happens if a required setting is missing so
//your approach to misconfigurations is clearer.
///Add a clear plan for handling missing settings, 
///such as validation at startup, fail-fast behavior for critical values, 
///and structured logging with useful metadata. You can also mention periodic review of 
///configuration files and monitoring alerts to reduce long-term risk.
using ModelBase_Minimal.Api.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Rota padrao para testar aplication
app.MapGet("/", () => { return new { state = "Hello World." }; }).ExcludeFromDescription();

//Carrega todas as rotas
app.MapApiEndPoints();

app.Run();


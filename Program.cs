var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.MapGet("/", () => new User("Michel", "Teste@teste.com"));

app.UseSwaggerUI();

app.Run();

public record User( string name, string email);
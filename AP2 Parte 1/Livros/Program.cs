var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/status", () => new
{
    status = "Online",
    mensagem = "Api está funcionando",
    dataHora = DateTime.Now
});

app.Run();

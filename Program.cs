var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/user", () => "Natan");
app.MapPost("/user", () => new { Name = "Natan Alves", Age = 40 });
app.MapGet("/Add", (HttpResponse response) =>
{
    response.Headers.Add("Teste", "Natan Alves");
    return new
    {
        Name = "Natan Alves",
        Age = 40
    };
});

app.MapPost("/saveprod", (Product product) =>
{
    return product.Code + " - " + product.Name;
});

app.Run();

public class Product
{
    public string Code { get; set; }
    public string Name { get; set; }
}

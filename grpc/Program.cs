using grpc.Data;
using grpc.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddGrpc();

builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-encoding", "Grpc-Accept-Encoding");

}));

var app = builder.Build();

app.UseGrpcWeb();
app.MapGrpcService<Server>().EnableGrpcWeb().RequireCors("AllowAll");
app.UseCors();

builder.Services.AddDbContext<AppDbContext>(options => builder.Configuration.GetConnectionString("pgsql"));

app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using assembly;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

//// chemin ver l'executable non autonnome 
//string grpc = @"..\common\common.csproj";

//// lancer l'éxécutable non autonome 
//ProcessStartInfo processStartInfo = new ProcessStartInfo(grpc);
//Process process = Process.Start(processStartInfo);

////attendre que le processus se termine
//process.WaitForExit();

////Récupérer le code de sortie du processus 
//int exitCode = process.ExitCode;

var channel = GrpcChannel.ForAddress("https://localhost:7096", new GrpcChannelOptions
{
    HttpHandler = new GrpcWebHandler(new HttpClientHandler())
});




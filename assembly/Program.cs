using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using assembly;
using System;
using System.Diagnostics;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

// chemin ver l'executable non autonnome 
string grpc = @"..\common\common.csproj";

// lancer l'éxécutable non autonome 
ProcessStartInfo processStartInfo = new ProcessStartInfo(grpc);
Process process = Process.Start(processStartInfo);

//attendre que le processus se termine
process.WaitForExit();

//Récupérer le code de sortie du processus 
int exitCode = process.ExitCode;



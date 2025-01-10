
using SalesTest.Extensions;
using Serilog;

namespace SalesTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .CreateBootstrapLogger();

            Log.Information("Starting up");

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                var configuration = builder.Configuration
                    .SetBasePath(Path.Combine(AppContext.BaseDirectory, "Configs"))
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile("serilog.json", optional: true, reloadOnChange: true) //���� ����������� serilog �������� � ��������� ����
                    .Build();

                builder.Host.UseSerilog((ctx, lc) => lc
                    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}")
                    .Enrich.FromLogContext()
                    .ReadFrom.Configuration(ctx.Configuration));

                var app = builder
                    .ConfigureServices()
                    .ConfigurePipeline();

                app.Run();
            }
            catch (Exception ex) when (ex is not HostAbortedException)
            {
                Log.Fatal(ex, "Unhandled exception");
            }
            finally
            {
                Log.Information("Shut down complete");
                Log.CloseAndFlush();
            }
        }
    }
}

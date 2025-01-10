using Microsoft.EntityFrameworkCore;
using SalesTest.Data;

namespace SalesTest.Extensions;

/// <summary>
/// Настройка конфигурации и пайплана вэб-сервера kestrel
/// </summary>
internal static class HostingExtension
{
    /// <summary>
    /// Конфигурация сервисов
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        var configuration = builder.Configuration;

       //Строки соединения для базы spd и wm соответсвенно
        var appDbConnction = configuration.GetRequiredConnectionString("MainConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite(appDbConnction);
        });

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        return builder.Build();
    }

    /// <summary>
    /// Конфигурация пайплайна
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseHsts();
        app.UseHttpsRedirection();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.UseAuthorization();
        app.MapControllers();
        return app;
    }
}
   



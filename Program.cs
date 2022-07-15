using System.Text;
using Microsoft.AspNetCore;
using Serilog;
using WebServicesEnrollment;

public class ProgramObject
{
    public static void Main(string[] args)
    {
      Log.Logger= new LoggerConfiguration().WriteTo.File("WebServiceEnrollment.out", Serilog.Events.LogEventLevel.Debug, "{Message:lj}{NewLine}", encoding: Encoding.UTF8).CreateLogger();
      CreateWebHostBuilder(args).Build().Run();
    }
    public static IWebHostBuilder CreateWebHostBuilder(string [] args) => 
    WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
}
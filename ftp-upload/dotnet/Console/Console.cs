using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace OM.AWS
{
    public class Console
    {
        public static void Main(string[] args)
        {
            //setup our DI
            var sc = new ServiceCollection();
            //sc.AddSingleton<LambdaHandler, LambdaHandler>();
            var serviceProvider=sc.AddLogging().BuildServiceProvider();

            /*var configuration = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", false, true)
                                .Build();*/

            //configure console logging
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace).AddFilter("System.Net", Microsoft.Extensions.Logging.LogLevel.Trace));
            //serviceProvider.GetService<ILoggerFactory>().AddConsole(null);

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<Console>();
            logger.LogDebug("Starting application");

            //do the actual work here
            //var lambdaHandler = serviceProvider.GetService<LambdaHandler>();
            //var classLogger = serviceProvider.GetService<ILogger<LambdaHandler>>();

            logger.LogInformation("Started");
            string path = "../local/sample-sqs-message.json";
            //object response = lambdaHandler.handleRequest(new FileStream(path, FileMode.Open), null).ConfigureAwait(false).GetAwaiter().GetResult();
            //logger.LogInformation(response.ToString());
            logger.LogInformation("Ended.");
        }
    }
}
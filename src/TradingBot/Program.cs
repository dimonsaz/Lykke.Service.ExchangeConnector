﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;
using TradingBot.Infrastructure.Configuration;
using Microsoft.AspNetCore.Hosting;
using TradingBot.Infrastructure.Logging;

namespace TradingBot
{
    class Program
    {
        private static readonly ILogger Logger = Logging.CreateLogger<Program>();

        static void Main(string[] args)
        {
            try
            {
	            var config = GetConfig(args);

                if (config.Logger.Enabled)
                    Logging.LoggerFactory.AddLykkeLog(config.AzureTable.StorageConnectionString, config.Logger.TableName);

	            
	            Logger.LogDebug("Waiting a bit for services up...");
	            Task.Delay(TimeSpan.FromSeconds(10)).Wait();
	        
	            
				var cycle = new GetPricesCycle(config);
				var task = cycle.Start();
	            
				Logger.LogInformation("Press Ctrl+C for exit");

	            var host = new WebHostBuilder()
		            .UseKestrel()
		            .UseContentRoot(Directory.GetCurrentDirectory())
		            .UseStartup<Startup>()
		            .UseUrls(config.AspNet.Host)
		            .Build();

	            host.Run(); // returns on Ctrl+C

	            cycle.Stop();
	            task?.Wait();

				Logger.LogInformation("The service is stopped.");
				Environment.Exit(0);
            }
            catch(Exception e)
            {
                Logger.LogError(new EventId(), e, "Application error");
                Environment.Exit(-1);
            }
        }
	
	    private static Configuration GetConfig(string[] args)
	    {
		    var configBuilder = new ConfigurationBuilder();

		    string settingsUrl = Environment.GetEnvironmentVariable("SettingsUrl");

		    if (string.IsNullOrEmpty(settingsUrl))
		    {
			    Logger.LogInformation("Empty SettingsUrl environment variable. Apply settings from appsettings.json file.");

			    configBuilder
					.SetBasePath(Directory.GetCurrentDirectory())
					.AddJsonFile("appsettings.json", optional: true)
					.AddCommandLine(args);
		    }
		    else
		    {
		        Logger.LogInformation("Apply settings from SettingsUrl");
			    
			    configBuilder
				    .AddJsonFile(new LykkeSettingsFileProvider(), path: settingsUrl, optional: false, reloadOnChange: false);    
		    }

		    Configuration config = Configuration.FromConfigurationRoot(configBuilder.Build());

		    return config;
	    }
    }
}

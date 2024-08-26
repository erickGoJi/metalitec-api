using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace worker.service.metalitec
{
    public class Report005: BackgroundService
    {
        private readonly ILogger<Report004> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private const string URL = "http://34.237.214.147/back/api_metalitec/";
        
        public Report005(ILogger<Report004> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }
        
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Report005 Starts");
            return base.StartAsync(cancellationToken);
        }
        
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Report005 Stops");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Report005 running at: {time}", DateTimeOffset.Now);
                try
                {
                    await PollUrl();
                }
                catch (OperationCanceledException ex)
                {
                    _logger.LogError(ex, "An error occurred while pulling urls");
                }
                finally
                {
                    await Task.Delay(600000, stoppingToken);
                }
            }
            
        }

        private async Task PollUrl()
        {
            try
            {
                _logger.LogInformation("Report005 Call Services.");
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(URL);
                client.Timeout = TimeSpan.FromMinutes(10);
                
                var response = await client.GetAsync("api/SupplierAssemblers/Assembly-Released-On-Site");;
                if (response.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/SupplierAssemblers/Assembly-Released-On-Site");
                else
                    _logger.LogWarning("{uri} is bad request", "api/SupplierAssemblers/Assembly-Released-On-Site");
                
                var response02 = await client.GetAsync("api/SupplierAssemblers/Program-Mounting");
                if (response02.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/SupplierAssemblers/Program-Mounting");
                else
                    _logger.LogWarning("{uri} is bad request", "api/SupplierAssemblers/Program-Mounting");
                
                var response03 = await client.GetAsync("api/SupplierAssemblers/Top-5");
                if (response03.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/SupplierAssemblers/Top-5");
                else
                    _logger.LogWarning("{uri} is bad request", "api/SupplierAssemblers/Top-5");
                
                var response04 = await client.GetAsync("api/SupplierAssemblers/Variation-Budget");
                if (response04.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/SupplierAssemblers/Variation-Budget");
                else
                    _logger.LogWarning("{uri} is bad request", "api/SupplierAssemblers/Variation-Budget");

                var response05 = await client.GetAsync("api/SupplierAssemblers/Payments-Assembly");
                if (response05.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/SupplierAssemblers/Payments-Assembly");
                else
                    _logger.LogWarning("{uri} is bad request", "api/SupplierAssemblers/Payments-Assembly");
                
                // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of;
                // for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
                client.Dispose();
            }
            catch (Exception e)
            {
                _logger.LogWarning($"API response error : {e.Message}");
            }

            await Task.WhenAll();
        }
    }
}
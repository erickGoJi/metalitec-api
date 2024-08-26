using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Timer = System.Timers.Timer;

namespace worker.service.metalitec
{
    public class Report002 : BackgroundService
    {
        private readonly ILogger<Report002> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private Timer _timer;
        private DateTime _scheduleTime;
        private const string URL = "http://34.237.214.147/back/api_metalitec/";

        public Report002(ILogger<Report002> logger, IHttpClientFactory httpClientFactory)
        {
            _timer = new Timer();
            _scheduleTime = DateTime.Today.AddDays(0).AddHours(7);
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Report002 Starts");
            return base.StartAsync(cancellationToken);
        }
        
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Report002 Stops");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Report002 running at: {time}", DateTimeOffset.Now);
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
                _logger.LogInformation("Report002 Call Services.");
            
                if (_timer.Interval != 24 * 60 * 60 * 1000)
                {
                    _timer.Interval = 24 * 60 * 60 * 1000;
                }  
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(URL);
                client.Timeout = TimeSpan.FromMinutes(10);
                
                var response = await client.GetAsync("api/FinancialReport/State-Results");;
                if (response.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/FinancialReport/State-Results");
                else
                    _logger.LogWarning("{uri} is bad request", "api/FinancialReport/State-Results");
                
                var response02 = await client.GetAsync("api/FinancialReport/Cash-Flow");
                if (response02.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/FinancialReport/Cash-Flow");
                else
                    _logger.LogWarning("{uri} is bad request", "api/FinancialReport/Cash-Flow");
                
                var response03 = await client.GetAsync("api/FinancialReport/Operating-Results-Summary");
                if (response03.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/FinancialReport/Operating-Results-Summary");
                else
                    _logger.LogWarning("{uri} is bad request", "api/FinancialReport/Operating-Results-Summary");
                
                var response04 = await client.GetAsync("api/FinancialReport/Budget-Advance");
                if (response04.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/FinancialReport/Budget-Advance");
                else
                    _logger.LogWarning("{uri} is bad request", "api/FinancialReport/Budget-Advance");

                var response05 = await client.GetAsync("api/FinancialReport/Main-Account-Evaluation");
                if (response05.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/FinancialReport/Main-Account-Evaluation");
                else
                    _logger.LogWarning("{uri} is bad request", "api/FinancialReport/Main-Account-Evaluation");
                
                var response06 = await client.GetAsync("api/FinancialReport/Balance-Sheet-Summary");
                if (response06.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/FinancialReport/Balance-Sheet-Summary");
                else
                    _logger.LogWarning("{uri} is bad request", "api/FinancialReport/Balance-Sheet-Summary");
                
                var response07 = await client.GetAsync("api/FinancialReport/Funding-Investment-Operations");
                if (response07.IsSuccessStatusCode)
                    _logger.LogInformation("{uri} is successfully", "api/FinancialReport/Funding-Investment-Operations");
                else
                    _logger.LogWarning("{uri} is bad request", "api/FinancialReport/Funding-Investment-Operations");
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
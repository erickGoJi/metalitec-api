using System.Net;
using System.Threading.Tasks;
using api.metalitec.project;
using dal.erpmet.Repository.FinancialReport;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Testing;
using test.metalitec.Fixtures;
using test.metalitec.Utils;
using Xunit;
using FluentAssertions;
using Newtonsoft.Json;


namespace test.metalitec
{
    public class FinancialReportControllerTests : IntegrationTest
    {
        public FinancialReportControllerTests(WebApplicationFactory<Startup> fixture) : base(fixture)
        {
        }
        
        [Fact]
        public async Task Get_Should_Return_State_Results()
        {
            var stateResults =
                await _client.GetAndDeserialize<FinancialReportRepository.EstadoResultado[]>(
                    "/api/FinancialReport/State-Results");
            stateResults.Should().HaveCount(7);
        }
        
        [Fact]
        public async Task GET_retrieves_weather_forecast()
        {
            var response = await _client.GetAsync("/weatherforecast");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
 
            var forecast = JsonConvert.DeserializeObject<FinancialReportRepository.EstadoResultado[]>(await response.Content.ReadAsStringAsync());
            forecast.Should().HaveCount(5);
        }

    }
}
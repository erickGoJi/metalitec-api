using System.Net.Http;
using api.metalitec.project;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualBasic.CompilerServices;
using Xunit;

namespace test.metalitec.Fixtures
{
    public class IntegrationTest : IClassFixture<ApiWebApplicationFactory>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        protected readonly HttpClient _client;
        public IntegrationTest(WebApplicationFactory<Startup> fixture)
        {
            _factory = fixture;
            _client = _factory.CreateClient();

            // if needed, reset the DB
            //_checkpoint.Reset(_factory.Configuration.GetConnectionString("SQL")).Wait();
        }
    }
}
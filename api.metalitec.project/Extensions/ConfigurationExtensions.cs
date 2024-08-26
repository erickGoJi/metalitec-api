using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using api.metalitec.project.Services.Logger;
using api.metalitec.project.ActionFilter;
using biz.admin.Repository.CatRole;
using biz.admin.Repository.File;
using biz.admin.Repository.Utility;
using biz.admin.Services.Email;
using biz.erpmet.Repository.User;
using dal.erpmet.Repository.User;
using biz.erpmet.Repository.FinancialReport;
using biz.erpmet.Repository.SupplierAssemblers;
using biz.erpmet.Repository.SupplierClassification;
using biz.metalitec.Repository.ProductionWorkOrderContract;
using dal.admin.Repository.CatRole;
using dal.admin.Repository.File;
using dal.admin.Repository.Utility;
using dal.erpmet.Repository.FinancialReport;
using dal.erpmet.Repository.SupplierAssemblers;
using dal.erpmet.Repository.SupplierClassification;
using dal.metalitec.Repository.ProductionWorkOrderContract;

namespace api.metalitec.project.Extensions
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("CorsPolicy",
            builder =>
            {
                builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithOrigins("http://localhost")
                .WithOrigins("http://localhost:4200")
                .WithOrigins("http://localhost:8100")
                .WithOrigins("http://demo-minimalist.com")
                .WithOrigins("http://34.237.214.147")
                .WithOrigins("https://my.premierds.com/")
                .WithOrigins("Ionic://localhost")
                .WithOrigins("capacitor://localhost")
                .WithOrigins("http://localhost:63410")
                .AllowCredentials();
            }));
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IFinancialReportRepository, FinancialReportRepository>();
            services.AddTransient<ISupplierClassificationRepository, SupplierClassificationRepository>();
            services.AddTransient<IProductionWorkOrderContractRepository, ProductionWorkOrderContractRepository>();
            services.AddTransient<ISupplierAssemblersRepository, SupplierAssemblersRepository>();
            services.AddTransient<biz.admin.Repository.User.IUserRepository, dal.admin.Repository.User.UserRepository>();
            services.AddTransient<ICatRoleRepository, CatRoleRepository>();
            services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IUtilityRepository, UtilityRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureFilters(this IServiceCollection services)
        {
            services.AddScoped<ValidationFilterAttribute>();
        }
    }
}

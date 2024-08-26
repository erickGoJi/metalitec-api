using AutoMapper;
using api.metalitec.project.Extensions;
using dal.erpmet.DBContext;
using dal.metalitec.DBContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using api.metalitec.project.Mapper;
using dal.admin.DBContext;

namespace api.metalitec.project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors();

            services.AddDbContext<AcecadContext>
            (options => options.UseSqlServer(Configuration.GetConnectionString("Metalitec"),
                sqlServerOptions => sqlServerOptions.CommandTimeout(400)))
            .AddDbContext<ERPMETContext>(
            (options => options.UseSqlServer(Configuration.GetConnectionString("ERPMET"),
                sqlServerOptions => sqlServerOptions.CommandTimeout(400))))
            .AddDbContext<MetalitecDataContext>(
                (options => options.UseSqlServer(Configuration.GetConnectionString("Admin"),
                    sqlServerOptions => sqlServerOptions.CommandTimeout(400))));
            services.AddControllers();

            services.ConfigureRepositories();
            services.ConfigureServices();
            services.AddSignalR();
            services.ConfigureFilters();
            //services.AddAutoMapper(typeof(Startup));
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc(config =>
            {
                config.RespectBrowserAcceptHeader = true;
                config.InputFormatters.Add(new XmlSerializerInputFormatter(config));
                config.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            })
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
                //.SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                    };
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "api.metalitec.project", 
                    Version = "v1", 
                    Description = "REPORTE 002 <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/002-EstadoResultados.xlsx\">002-Estado Resultados</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/002-Avance_presupuestal_actual.xlsx\">002-Avance presupuestal actual</a> <br>" +
                                  "<a href=\"http://34.237.214.147back/api_metalitec/Files/002-Avance_presupuestal_contratado.xlsx\">002-Avance Presupuestal Contratatdo</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/002-EvolucionCuentasPrincipalesCT.xlsx\">002-EvolucionCuentasPrincipalesCT</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/002-FondeoOperacionesInversiones.xlsx\">002-Fondeo Operaciones Inversiones</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/002-ResumenBalanceGeneral.xlsx\">002-Resumen Balance General</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/002-Resumen Resultados Operativos.xlsx\">002-Resumen Resultados Operativos</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/002-FlujoEfectivo.xlsx\">002-Flujo de Efectivo</a> <br>" +
                                  "REPORTE 004 <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/004-Familia de Materiales.xlsx\">004-Familia de Materiales</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/004-Historial de compras.xlsx\">004-Historial de compras</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/004-Precio Tendencia.xlsx\">004-Precio Tendencia</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/004-Top5.xlsx\">004-Top5</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/004-Total Proveedores.xlsx\">004-Total Proveedores</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/004-Proyectos.xlsx\">004-Proyectosa></a> <br>" +
                                  "REPORTE 005 <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/005-Montaje Programa.xlsx\">005-Montaje Programa</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/005-Pagos  Montaje.xlsx\">005-Pagos  Montaje</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/005-Top.xlsx\">005-Top</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/005-Variación Presupuesto.xlsx\">005-Variación Presupuesto</a> <br>" +
                                  "<a href=\"http://34.237.214.147/back/api_metalitec/Files/005-Montaje liberado en obra.xlsx\">0005-Montaje liberado en obra</a> <br>"
                });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            services.AddSwaggerGenNewtonsoftSupport();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "api.metalitec.project v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
#if DEBUG
                app.UseSwagger().UseDeveloperExceptionPage();
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Metalitec API V1");
#else
                c.SwaggerEndpoint("/back/api_metalitec/swagger/v1/swagger.json", "Metalitec Web API V1");
#endif
            });
        }
    }
}

//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.OpenApi.Models;
//using Business.Abstract;
//using Business.Constants;
//using Core.Utilities.Results;
//using DataAccess.Abstract;
//using Entities.Concrete;
//using Entities.DTOs;
//using Business.Concrete;
//using DataAccess.Concrete.EntityFramework;
//using Core.Utilities.Security.JWT;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.IdentityModel.Tokens;
//using Core.Utilities.Security.Encryption;
//using Core.Utilities.IoC;
//using Core.Extensions;
//using Core.DependencyResolvers;

//namespace WebAPI
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllers();
//            //services.AddSingleton<IProductService, ProductManager>();
//            //services.AddSingleton<IProductDal, EfProductDal>();

//            services.AddCors(options =>
//            {
//                options.AddPolicy("AllowOrigin",
//                    builder => builder.WithOrigins("http://localhost:4200"));
//            });

//            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

//            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//                .AddJwtBearer(options =>
//                {
//                    options.TokenValidationParameters = new TokenValidationParameters
//                    {
//                        ValidateIssuer = true,
//                        ValidateAudience = true,
//                        ValidateLifetime = true,
//                        ValidIssuer = tokenOptions.Issuer,
//                        ValidAudience = tokenOptions.Audience,
//                        ValidateIssuerSigningKey = true,
//                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
//                    };
//                });
//            //ServiceTool.Create(services);
//            services.AddDependencyResolvers(new ICoreModule[] {
//                new CoreModule()
//            });

//            // Configure Swagger/OpenAPI
//            services.AddEndpointsApiExplorer();
//            services.AddSwaggerGen(c =>
//            {
//                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API Name", Version = "v1" });
//            });
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI(c =>
//                {
//                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name v1");
//                    c.RoutePrefix = string.Empty;
//                });
//            }
//            app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

//            app.UseHttpsRedirection();

//            app.UseRouting();

//            app.UseAuthentication();

//            app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });
//        }
//    }
//}

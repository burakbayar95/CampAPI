using Camp.Business;
using Camp.Business.Extensions;
using Movies.DataAccess.Data;
using Camp.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Movies.Business;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Camp.API
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
            services.AddControllers();
            services.AddMapperConfiguration();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<ICampService, CampService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IGenreRepository,EFGenreRepository>();
            services.AddScoped<ICampResponsitory, EFCampRepository>();//ICampResponsitory,
            services.AddScoped<ILoginRepository, EFLoginRepository>();//ILoginRepository,
            var connectionString = Configuration.GetConnectionString("db");
            services.AddDbContext<CampsDBContext>(options => options.UseSqlServer(connectionString));
            services.AddSwaggerGen(option => option.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Turkey Camping API",
                Contact = new OpenApiContact
                {
                    Email = "95burakbayar@gmail.com",
                    Name = "Burak BAYAR"
                },
                Version="v1"
            }));
            var issuer = Configuration.GetSection("Bearer")["Issuer"];
            var audince = Configuration.GetSection("Bearer")["Audince"];
            var key = Configuration.GetSection("Bearer")["SecurityKey"];
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateActor = true,
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = issuer,
                    ValidAudience = audince,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
                };
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseSwagger();

            app.UseSwaggerUI(opt=>opt.SwaggerEndpoint("/swagger/v1/swagger.json","Camp.API"));

            //app.UseSwaggerUI(c =>
            //{
            //    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
            //    c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "Camp.API");
            //});

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

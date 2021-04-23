using AutoMapper;
using DongolOfLegends.API.ApiHelpers;
using DongolOfLegends.API.ApiHelpers.Contracts;
using DongolOfLegends.API.BusinessLayer.Profiles;
using DongolOfLegends.API.DAC.Clients;
using DongolOfLegends.API.DAC.Context;
using DongolOfLegends.API.DAC.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PecTec.Riot.Core;
using PecTec.Riot.Core.Interfaces;
using PecTec.Riot.LoL;
using PecTec.Riot.LoL.Interfaces;

namespace DongolOfLegends.API
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
            services.AddHttpClient(); 
            services.AddMemoryCache();
            services.AddScoped<IClient, DOLClient>();
            services.AddScoped<ILeagueData, LeagueData>();
            services.AddDbContextFactory<DongolXContext>(options => options.UseSqlServer(Configuration["Global:ConnectionStrings:DONGOLX"]));
            services.AddTransient<PecTecClientOptions>(options => new PecTecClientOptions
            {
                RiotTokenString = Configuration["Riot:Api:DeveloperKey"],
                RiotTokenStringHeader = Configuration["Riot:Api:TokenHeader"]
            });
            services.AddSingleton<IPecTecClient, PecTecClient>();
            services.AddSingleton<IStaticDataRetrieve, StaticDataRetrieve>();
            services.AddSingleton<ILiveDataRetrieve, LiveDataRetrieve>();
            services.AddScoped<IChampionRepository, ChampionRepository>();
            services.AddScoped<ISummonerRepository, SummonerRepository>();
            services.AddScoped(s =>
            {
                return new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<ChampionProfiles>();
                }).CreateMapper();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

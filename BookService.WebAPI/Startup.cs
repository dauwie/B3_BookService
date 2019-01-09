using BookService.WebAPI.Models;
using BookService.WebAPI.Repositories;
using BookService.WebAPI.Services.Automapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookService.WebAPI
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
            var config = new AutoMapper.MapperConfiguration( cfg => { cfg.AddProfile(new AutMapperProfileConfiguration()); });
            var mapperke = config.CreateMapper();
            services.AddSingleton(mapperke);
            services.AddDbContext<BookServiceContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BookService")));
            services.AddScoped<AuthorRepository>();
            services.AddScoped<PublisherRepository>();
            services.AddScoped<BookRepository>();
            services.AddScoped<RatingRepository>();
            services.AddScoped<ReaderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //AutoMapper.Mapper.Initialize(
                
            //    cfg =>
            //    {
            //        cfg.CreateMap<Models.Book>, DTO.BookBasic>().For
            //    })

            app.UseMvc();
        }
    }
}

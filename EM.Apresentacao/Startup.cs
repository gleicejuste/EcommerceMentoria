using EM.Data;
using EM.Data.Repostory;
using Microsoft.EntityFrameworkCore;

namespace EM.Apresentacao
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
      
            services.AddScoped<IClienteRepository, ClienteRepository>();
            
            services.AddDbContext<ContextoPrincipal>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("EMConnectionString")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
              
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

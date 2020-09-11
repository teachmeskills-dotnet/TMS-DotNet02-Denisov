using Denisov.BLL.Services;
using Denisov.Common.Interfaces;
using Denisov.DAL;
using Denisov.DAL.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Denisov.TobaccoStore
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
            services.AddControllersWithViews();

            services.AddDbContext<DenisovDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly("Denisov.DAL")));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DenisovDbContext>();

            services.AddScoped(typeof(IRepository<>), typeof(RepositoryManager<>));

            services.AddTransient<RandomTobaccoService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

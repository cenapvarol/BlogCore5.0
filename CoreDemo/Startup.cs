using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo
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
            services.AddControllersWithViews();

            //Session yani oturumu a�abilmesi i�in bu parametrennin yaz�lmas� gerekiyor.
            services.AddSession();

            //Yazm�� oldu�umuz servise proje seviyesinde Authorize etmi� oluyoruz  yani sisteme login olmayan kullan�c� uygulamalara eri�imi engellenmi� olacak.
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                        .RequireAuthenticatedUser()
                        .Build();
                config.Filters.Add(new AuthorizeFilter(policy));

            });

            //Burada yapmak i,stedi�imiz i�lem ise  Layout da buluna login olmadan anasayfaya veya ba�ka sekmeye  t�klad���nda login sayfas�na y�nlendirlmesi.
            services.AddMvc();
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(x =>
                {
                    x.LoginPath = "/Login/Index";

                }
                );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Eklemi� oldu�umuz a�a��daki parametre kullan�c� url k�sm�n� yanl�� girdi�inde kullan�c�ya hatay� g�stermek ve ana sayfaya y�nlendirmek
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //Authorize i�lemi i�in bu parametreninde eklenmesi gerekiyor.
            app.UseSession();

            //Authorize Authentication i�lemi i�in bu parametreninde eklenmesi gerekiyor.
            app.UseAuthentication();

            app.UseRouting();

            //Authorize i�lemi i�in bu parametreninde eklenmesi gerekiyor.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TwitterDirectory {
    public class Startup {
        private readonly ILogger<Startup> _logger;

        public Startup(IConfiguration configuration, ILogger<Startup> logger) {
            Configuration = configuration;

            _logger = logger;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {

            var consumerKey = Configuration["Authentication:Twitter:ConsumerAPIKey"];
            var consumerSecret = Configuration["Authentication:Twitter:ConsumerAPISecret"];

            _logger.LogInformation("consumer key - {0}", consumerKey);
            _logger.LogInformation("consumer secret - {0}", consumerSecret);

            services
                .AddAuthentication(options => { })
                .AddCookie("C")
                .AddTwitter("Twitter", twitterOptions => {
                    twitterOptions.SignInScheme = "C";
                    twitterOptions.ConsumerKey = consumerKey;
                    twitterOptions.ConsumerSecret = consumerSecret;
                });

            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseExceptionHandler("/Home/Error");
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}"
                );
            });
        }
    }
}

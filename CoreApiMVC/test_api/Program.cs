using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //builder.Services.AddDbContext(options=>{options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); });
        //var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
        //Enable CORS
        //builder.Services.AddCors(options => {
        //  options.AddPolicy(name: myAllowSpecificOrigins,
        //      builder => {
        //          builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
        //      }
        //  );
        //});
        //app.UseCors(myAllowSpecificOrigins);

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>();  });
    }
}

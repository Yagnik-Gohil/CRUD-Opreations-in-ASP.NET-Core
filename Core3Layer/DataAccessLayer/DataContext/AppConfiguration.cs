using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.DataContext
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            var congigBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            congigBuilder.AddJsonFile(path, false);
            var root = congigBuilder.Build();
            var appSettings = root.GetSection("ConnectionStrings:AppConnection");
            sqlConnectionString = appSettings.Value;
        }
        public string sqlConnectionString { get; set; }
    }
}

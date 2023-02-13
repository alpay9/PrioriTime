using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using PrioriTime.Models;
using Microsoft.AspNetCore.Hosting;

namespace PrioriTime.Services
{
    public class JsonFileActivityService
    {
        public JsonFileActivityService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "activities.json"); }
        }

        public IEnumerable<Activity> GetActivities()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Activity[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}

﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using PrioriTime.Models;
using Microsoft.AspNetCore.Hosting;

namespace PrioriTime.Services
{
    public class JsonFileCategoryService
    {
        public JsonFileCategoryService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "categories.json"); }
        }

        public IEnumerable<Category> GetCategories()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Category[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrioriTime.Models;
using PrioriTime.Services;

namespace PrioriTime.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileCategoryService CategoryService;
        public JsonFileActivityService ActivityService;
        public IEnumerable<Category> Categories { get; private set; }
        public IEnumerable<Activity> Activities { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileCategoryService categoryService,
            JsonFileActivityService activityService)
        {
            _logger = logger;
            CategoryService = categoryService;
            ActivityService = activityService;
        }

        public void OnGet()
        {
            Categories = CategoryService.GetCategories();
            Activities = ActivityService.GetActivities();
        }
    }
}
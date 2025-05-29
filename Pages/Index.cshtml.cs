using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration Configuration;
 
        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }
 
        public ContentResult OnGet()
        {
            var db_user = Configuration["DB_USER"];
            var db_pass = Configuration["DB_PASS"];
            return Content($"db user : {db_user} \n" +
                $"db pass : {db_pass}");
        }
    }
}

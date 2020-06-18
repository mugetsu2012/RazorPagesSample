using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages
{
    public class ItemModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet(int id)
        {
            Message = "The id is " + id;
        }
    }
}

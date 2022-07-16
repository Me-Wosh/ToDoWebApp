using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoWebApp.Entities;

namespace ToDoWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _dbContext;
        [BindProperty]
        public ToDoTable table { get; set; }

        public CreateModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _dbContext.ToDoTable.AddAsync(table);
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}

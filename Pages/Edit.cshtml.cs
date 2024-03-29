using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoWebApp.Entities;

namespace ToDoWebApp.Pages
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _dbContext;
        [BindProperty]
        public ToDoTable Table { get; set; }

        public EditModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet(int id)
        {
            Table = _dbContext.ToDoTable.Find(id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                _dbContext.ToDoTable.Update(Table);
                await _dbContext.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}

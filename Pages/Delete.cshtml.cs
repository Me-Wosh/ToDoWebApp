using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoWebApp.Entities;

namespace ToDoWebApp.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _dbContext;
        [BindProperty]
        public ToDoTable Table { get; set; }
        public DeleteModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet(int id)
        {
            Table = _dbContext.ToDoTable.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var tableFromDb = _dbContext.ToDoTable.Find(Table.Id);

            if (tableFromDb is not null)
            {
                _dbContext.Remove(tableFromDb);
                await _dbContext.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}

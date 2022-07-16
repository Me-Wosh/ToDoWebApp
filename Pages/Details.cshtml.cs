using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoWebApp.Entities;

namespace ToDoWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _dbContext;
        public ToDoTable Table { get; set; }

        public DetailsModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet(int id)
        {
            Table = _dbContext.ToDoTable.Find(id);
        }
    }
}

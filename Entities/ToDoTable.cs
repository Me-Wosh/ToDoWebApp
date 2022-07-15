using System.ComponentModel.DataAnnotations;

namespace ToDoWebApp.Entities
{
    public class ToDoTable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        [Range(1, 5)]
        public short ImportanceLevel { get; set; }
    }
}

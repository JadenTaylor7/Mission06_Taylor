using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mission06_Taylor.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? CategoryName { get; set; }
        public string Title { get; set; }
        [Range(1000, 2027)]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}

//Todo: add CategoryId, 
//Before Notes, add public int CopiedToPlex

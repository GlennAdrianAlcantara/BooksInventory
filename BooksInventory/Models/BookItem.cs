using System;
using System.ComponentModel.DataAnnotations;

namespace BooksInventory.Models
{
    public class BookItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime PublishedDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}

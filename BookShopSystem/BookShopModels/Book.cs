using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopSystem.Models
{

    public class Book
    {
        private ICollection<Category> category;

        public Book()
        {
            this.category = new HashSet<Category>();
        }

        [Key]
        public int BookId { get; set; } //Ptimary key

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Descripton { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Copies { get; set; }

        public int AuthorId { get; set; }

        [Required]
        public Type Edition { get; set; }

        public DateTime ReleaseDate { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public virtual ICollection<Category> Categoryes

        {
            get { return this.category; }
            set { category = value; }
        }

        public virtual Author Authors { get; set; }
    }
}
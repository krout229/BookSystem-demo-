using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookSystem.Models
{
    public class Book
    {
        [Key]//Sets PK
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//AutoIncriment
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
    }
}

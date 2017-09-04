using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheProject.Models
{
    public class Deck
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A deck must have a name")]
        public string Name { get; set; }

        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Domain
{
    public class Book : Super
    {

        [Required]
        [StringLength(32, ErrorMessage = "There can only be 32 characters in the title")]

        public string title { get; set; }
        public int pages { get; set; }
        public DateTime published { get; set; }

        [ForeignKey("Author.Id")]
        public int authorId { get; set; }



    }
}

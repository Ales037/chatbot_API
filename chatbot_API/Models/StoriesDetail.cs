using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace chatbot_API.Models
{
    public class StoriesDetail
    {


        [Key]
        public int Stories_Id { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Stories_headName { get; set; }


        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Stories_Text { get; set; }

    }
}

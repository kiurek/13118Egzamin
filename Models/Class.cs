using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13118EgzaminPraktyczny.Models
{
    public class Class
    {
        public int Id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string author { get; set; }

        [Required]
        public string price { get; set; }
    }
}

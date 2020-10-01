using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi2020.Models
{
    public class Quote
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public ICollection<QuoteTag> QuoteTags { get; set; }
    }
}

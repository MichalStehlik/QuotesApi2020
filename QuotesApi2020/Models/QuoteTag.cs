using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi2020.Models
{
    public class QuoteTag
    {
        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
        [Key]
        public int TagId { get; set; }
        [ForeignKey("QuoteId")]
        public Quote Quote { get; set; }
        [Key]
        public int QuoteId { get; set; }
        public ICollection<Quote> Quotes { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}

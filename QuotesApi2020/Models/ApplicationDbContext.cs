using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi2020.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<QuoteTag> QuoteTags { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<QuoteTag>().HasKey(qt => new { qt.QuoteId, qt.TagId});
            builder.Entity<Tag>().HasData(new Tag { Id = 1, Text = "Werich, Jan", Type = TagType.Author});
            builder.Entity<Tag>().HasData(new Tag { Id = 2, Text = "Hloupost", Type = TagType.Theme });
            builder.Entity<Tag>().HasData(new Tag { Id = 3, Text = "Česky", Type = TagType.Language });
            builder.Entity<Quote>().HasData(new Quote { Id = 1, Text = "<p>Hloupost je největší zlo.</p>" });
            builder.Entity<QuoteTag>().HasData(new QuoteTag { QuoteId = 1, TagId = 1 });
            builder.Entity<QuoteTag>().HasData(new QuoteTag { QuoteId = 1, TagId = 2 });
            builder.Entity<QuoteTag>().HasData(new QuoteTag { QuoteId = 1, TagId = 3 });
        }
    }
}

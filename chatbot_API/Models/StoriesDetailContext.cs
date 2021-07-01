using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatbot_API.Models
{
    public class StoriesDetailContext : DbContext
    {

        public StoriesDetailContext(DbContextOptions<StoriesDetailContext> options) : base(options)
        { }

        public DbSet<StoriesDetail> StoriesDetails { get; set; }

    }
}

using com.tweetapp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp
{
    public class TweetAppDbContext : DbContext
    {
        public TweetAppDbContext()
        {
        }

        public TweetAppDbContext(DbContextOptions<TweetAppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Tweet> Tweets { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Add your connection string here");
                //add the connection string here for database connection
            }
        }
    }
}

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
                optionsBuilder.UseSqlServer("Server = LTIN148207\\SQLSERVEREXPRESS; Database = tweetApp; Trusted_Connection = true; MultipleActiveResultSets = true; User ID = sa; Password = sqlserver2019;");
            }
        }
    }
}

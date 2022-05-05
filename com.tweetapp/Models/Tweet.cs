using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.tweetapp.Models
{
    public class Tweet
    {
        [Key]
        public int TweetId { get; set; }

        //public int UserId { get; set; }

        //[DataType(DataType.DateTime)]
        //public DateTime? TweetTime { get; set; }

        //public string TweetMessage { get; set; }

        //public virtual ICollection<User> Users { get; set; }

        public string EmailId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? TweetTime { get; set; }
        public string TweetMessage { get; set; }
    }
}

using com.tweetapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.DataAccessObject
{
    public interface ITweetRepository
    {
        public bool UserLogin(string emailId, string password);
        public bool UserRegistration(User user);
        public bool PostTweet(Tweet tweet);
        public List<Tweet> GetTweetById(string EmailID);

        public List<Tweet> GetAllTweet();

        public bool Logout(string user);
        public bool ForgetPassword(string user, DateTime dob, string pass);
        public bool ResetPassword(string user, string oldpass, string pass);
    }
}

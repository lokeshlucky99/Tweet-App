using com.tweetapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.DataAccessObject
{
    public class TweetRepository : ITweetRepository
    {
        private TweetAppDbContext _dbContext;

        public TweetRepository(TweetAppDbContext dbContext)
        {
            _dbContext= dbContext;
        }


        public bool UserLogin(string emailId, string password)
        {
            var regUserDetails = _dbContext.Users
                                      .Where(s => s.EmailId == emailId && s.Passcode == password).FirstOrDefault();
            if (regUserDetails != null)
            {
                regUserDetails.Status = true;
                _dbContext.SaveChanges();
                return true;
            }
                
            
            else
                return false;
        }

        public bool Logout(string user)
        {
            var regUserDetails = _dbContext.Users
                                      .Where(s => s.EmailId == user).FirstOrDefault();
            if (regUserDetails != null)
            {
                regUserDetails.Status = false;
                _dbContext.SaveChanges();
                return true;
            }


            else
                return false;
        }


        public bool UserRegistration(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool PostTweet(Tweet tweet)
        {
            try
            {
                _dbContext.Tweets.Add(tweet);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<Tweet> GetTweetById(string EmailID)
        {
            List<Tweet> tweetAll = new List<Tweet>();

            tweetAll = _dbContext.Tweets.Where(x => x.EmailId == EmailID).ToList<Tweet>();
            return tweetAll;
        }



        public List<Tweet> GetAllTweet()
        {
            List<Tweet> tweetAll = new List<Tweet>();
            tweetAll = _dbContext.Tweets.ToList();
            return tweetAll;
        }


        public bool ForgetPassword(string user, DateTime dob, string pass)
        {
            var result = _dbContext.Users.Where(x => x.EmailId == user && x.Dob == dob).FirstOrDefault();
            if (result != null)
            {
                result.Passcode = pass;
                _dbContext.SaveChanges();
                return true;

            }

            else
                return false;
        }
   

        public bool ResetPassword(string user, string oldpass, string pass)
        {
            var result = _dbContext.Users.Where(x => x.EmailId == user && x.Passcode == oldpass).FirstOrDefault();
            if (result != null)
            {
                result.Passcode = pass;
                _dbContext.SaveChanges();
                return true;

            }

            else
                return false;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Service
{
    public interface IUserService
    {
        public void WelcomeConsole();
        public void IntroPageNonLoggedUser();
        public bool UserRegistration();

    }
}

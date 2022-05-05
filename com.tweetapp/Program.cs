using com.tweetapp.DataAccessObject;
using com.tweetapp.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace com.tweetapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            Configure(services);
            IServiceProvider provider = services.BuildServiceProvider();
            var service = provider.GetService<IUserService>();
            service.IntroPageNonLoggedUser();
        }
        private static void Configure(IServiceCollection service)
        {
            service.AddSingleton<ITweetRepository, TweetRepository>();
            service.AddScoped<IUserService, UserService>();
            service.AddDbContext<TweetAppDbContext>();

        }
    }
}

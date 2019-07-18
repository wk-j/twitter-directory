using System;
using System.Threading.Tasks;

namespace Twitter {

    class Program {
        static async Task Main(string[] args) {
            var consumerKey = "";
            var consumerKeySecret = "";
            var accessToken = "";
            var accessTokenSecret = "";

            var twitter = new TwitterApi(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            var rs = await twitter.Tweet("Test Twitter API");

            Console.WriteLine(rs);
        }
    }
}

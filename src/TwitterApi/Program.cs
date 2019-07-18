using System;
using System.Threading.Tasks;

namespace Twitter {

    class Program {
        static async Task Main(string[] args) {
            var consumerKey = "";
            var consumerKeySecret = "";
            var twitter = new Twitter2.Twitter(consumerKey, consumerKeySecret);
            var bearer = twitter.BearerToken;

            Console.WriteLine(bearer);


        }
    }
}

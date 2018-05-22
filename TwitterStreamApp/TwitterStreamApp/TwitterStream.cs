using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace TwitterStreamApp
{
    class TwitterStream : IObservable<TweetItem>
    {
        public TwitterStream()
        {
            myObservers = new List<IObserver<TweetItem>>();
            Task.Factory.StartNew(Start);
        }

        private List<IObserver<TweetItem>> myObservers;

        public IDisposable Subscribe(IObserver<TweetItem> observer)
        {
            if (!myObservers.Contains(observer))
            {
                myObservers.Add(observer);
            }
            return new Unsubscriber(observer, myObservers);
        }

        private void Start()
        {
            string accessToken = "842485645725581312-Cbj6GPdXWIeFg678cunLWheYExRBZRP";
            string accessTokenSecret = "";
            string consumerKey = "8XgXv2DwwDcrUopRR9wBjJTtQ";
            string consumerSecret = "";

            // Set up your credentials (https://apps.twitter.com)
            Auth.SetUserCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            var user = User.GetAuthenticatedUser();

            var stream = Stream.CreateSampleStream();
            stream.TweetReceived += (sender, args) =>
                {
                    OnNewTweet(args.Tweet);
                    //Console.WriteLine(args.Tweet);
                };
            stream.StartStream();
            //IToken token = new Token(userKey, userSecret,
            //    consumerKey, consumerSecret);
            //SimpleStream stream = new
            //    SimpleStream("https://stream.twitter.com/1.1/statuses/sample.json");
            //stream.StartStream(token, tweet => OnNewTweet(tweet));
        }

        private void OnNewTweet(ITweet tweet)
        {
            TweetItem ti = new TweetItem(tweet);
            foreach (IObserver<TweetItem> observer in myObservers)
            {
                if (observer != null)
                {
                    observer.OnNext(ti);
                }
            }
        }
    }
}

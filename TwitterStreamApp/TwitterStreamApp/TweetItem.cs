using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Models;

namespace TwitterStreamApp
{
    public class TweetItem
    {
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public string Language { get; set; }
        public int Followers { get; set; }
        public int Friends { get; set; }

        public TweetItem() { }

        public TweetItem(ITweet tweet)
        {
            Text = tweet.Text;
            CreationDate = tweet.CreatedAt;
            User = tweet.InReplyToScreenName;
            if (tweet.Language != null)
            {
                Language = tweet.Language.ToString();
            }
        }

        public override string ToString()
        {
            return User + ": " + Text;
        }
    }
}

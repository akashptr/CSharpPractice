using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Intermediate
{
    internal class StackOverflowPost
    {
        string title;
        string description;
        DateTime dateTime;
        private int vote;
        public StackOverflowPost(string title, string description, DateTime dateTime)
        {
            this.title = title;
            this.description = description;
            this.dateTime = dateTime;
            vote = 0;
        }
        public void UpVote()
        {
            vote++;
        }
        public void DownVote()
        {
            if (vote != 0)
                vote--;
        }
        public int getVote()
        {
            return vote;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter5_2
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        private int feedMultiplier = 30;
        private int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;

        public Farmer(int x, int y)
        {
            this.feedMultiplier = y;
            NumberOfCows = x;
        }

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}

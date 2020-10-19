using System;

namespace ClassLibrary1
{
    public class Episode
    {
        int viewers;
        double ratingSum;
        double maxRating;

        public Episode()
        {
            viewers = 0;
            ratingSum = 0;
            maxRating = 0;
        }
        
        public Episode(int viewers, double ratingSum, double maxRating)
        {
            this.viewers = viewers;
            this.ratingSum = ratingSum;
            this.maxRating = maxRating;
        }

        public void AddView(double rating)
        {
            ratingSum += rating;
            viewers += 1;
            if (rating > maxRating)
                maxRating = rating;
        }

        public double GetMaxScore()
        {
            return maxRating;
        }

        public double GetAverageScore()
        {
            return ratingSum / viewers;
        }

        public int GetViewerCount()
        {
            return viewers;
        }
    }
}

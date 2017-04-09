namespace TravelReviewProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TravelReviewProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TravelReviewProject.Models.TravelReviewProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TravelReviewProject.Models.TravelReviewProjectContext context)
        {

            context.Hotels.AddOrUpdate(x => x.HotelID,
         new Hotel() { HotelID = 1, HotelLocation = "Chicago" },
         new Hotel() { HotelID = 2, HotelLocation = "New York City" },
         new Hotel() { HotelID = 3, HotelLocation = "Boston" }
         );

            context.Users.AddOrUpdate(x => x.UserID,
                new User()
                {
                    UserID = 1,
                    FirstName = "Maria",
                    LastName = "Arroyo",
                    City = "Cleveland",
                    State = "Ohio",
                    ReviewComment = "I really liked the area and the pool was nice. Beds were so comfy!",
                    HotelID = 1
                    
                },
                new User()
                {
                    UserID = 2,
                    FirstName = "Claire",
                    LastName = "Schrimpf",
                    City = "Nashville",
                    State = "Tennessee",
                    ReviewComment = "Breakfast was free and really good. Room service was top notch. This is where I always stay when I'm in the area",
                    HotelID = 2
                },
                new User()
                {
                    UserID = 3,
                    FirstName = "Rich",
                    LastName = "Barker",
                    City = "Austin",
                    State = "Texas",
                    ReviewComment = "Hotel was really nice and let me check out late without paying for an extra night. Staff was super friendly. Would definitely stay here again",
                    HotelID = 3
                },
                new User()
                {
                    UserID = 4,
                    FirstName = "Bridget",
                    LastName = "Ryan",
                    City = "Columbus",
                    State = "Ohio",
                    ReviewComment = "The hotel was so close to my business meeting. Great view of the city from my room. Thanks for making my trip so relaxing!",
                    HotelID = 1
                }
                );
        }
    }
}

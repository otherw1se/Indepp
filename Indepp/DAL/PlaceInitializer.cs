﻿using Indepp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indepp.DAL
{
    public class PlaceInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PlaceContext>
    {
        protected override void Seed(PlaceContext context)
        {
            var places = new List<Place> 
            {
                new Place {ID = 1, Name = "La Bottega Milanese", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 2, Name = "Test Coffee", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 3, Name = "Good Coffee", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 4, Name = "Shit Coffee", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 5, Name = "The Old Black Cat", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 6, Name = "Name me what you like", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 7, Name = "Burning hell", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 8, Name = "Sweet lords coffee", Category = "Coffee", Reviewed = true, UserContributed = false },
                new Place {ID = 9, Name = "Belgrave Music Hall and Canteen", Category = "Food", Reviewed = true, UserContributed = false },
                new Place {ID = 10, Name = "JUST FOOD", Category = "Food", Reviewed = true, UserContributed = false },
                new Place {ID = 11, Name = "Yorkshire Farm", Category = "Farm", Reviewed = true, UserContributed = false },
                new Place {ID = 12, Name = "Leeds Farm", Category = "Farm", Reviewed = true, UserContributed = false },
                new Place {ID = 13, Name = "The Light", Category = "CraftShop", Reviewed = true, UserContributed = false },
                new Place {ID = 14, Name = "The Dark", Category = "CraftShop", Reviewed = true, UserContributed = false },
                new Place {ID = 15, Name = "AVIO", Category = "Fashion", Reviewed = true, UserContributed = false },
                new Place {ID = 16, Name = "MU", Category = "Fashion", Reviewed = true, UserContributed = false }
            };

            places.ForEach(p => context.Places.Add(p));
            context.SaveChanges();

            var addresses = new List<Address>
            {
                new Address { PlaceID = 1, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire", Latitude = (decimal)53.798110, Longitude =  (decimal)-1.547736 },
                new Address { PlaceID = 2, City = "Manchester", Country = "United Kingdom", County = "Midlands" },
                new Address { PlaceID = 3, City = "London", Country = "United Kingdom", County = "Midlands" },
                new Address { PlaceID = 4, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 5, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 6, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 7, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 8, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 9, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire", Latitude = (decimal)53.801000, Longitude =  (decimal)-1.540980 },
                new Address { PlaceID = 10, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 11, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire", Latitude = (decimal)53.974836, Longitude =  (decimal)-1.134820 },
                new Address { PlaceID = 12, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 13, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire" },
                new Address { PlaceID = 14, City = "Leeds", Country = "United Kingdom", County = "West Yorkshire", Latitude = (decimal)53.799950, Longitude =  (decimal)-1.562671 },
                new Address { PlaceID = 15, City = "Manchester", Country = "United Kingdom", County = "Midlands" },
                new Address { PlaceID = 16, City = "London", Country = "United Kingdom", County = "London", Latitude = (decimal)51.516893, Longitude =  (decimal)-0.127691 }
            };

            addresses.ForEach(a => context.Addresses.Add(a));
            context.SaveChanges();

            var placeDescriptions = new List<PlaceDescription>
            {
                new PlaceDescription { PlaceID = 1, Description = "La bottega is..."},
                new PlaceDescription { PlaceID = 2, Description = "Once upon a time"},
                new PlaceDescription { PlaceID = 3, Description = "test description"}
            };

            placeDescriptions.ForEach(pd => context.PlaceDescriptions.Add(pd));
            context.SaveChanges();

            var blogPosts = new List<BlogPost>
            {
                new BlogPost {ID = 1, Title = "Welcome to our website", ShortDescription = "Hello and welcome. We pleased to announce, that ...", Description = "pam", PostedOn = new DateTime(2015, 7, 12, 22, 37, 15)},
                new BlogPost {ID = 2, Title = "First thing to do in the mornings", ShortDescription = "It feels good to start your day with a great cup of coffee...", Description = "param", PostedOn = new DateTime(2015, 7, 12, 23, 0 , 0)}
            };

            blogPosts.ForEach(bp => context.BlogPosts.Add(bp));
            context.SaveChanges();

            var articles = new List<Article>
            {
                new Article {ID = 1, Title = "test1", Description = "test1", PostedOn = new DateTime(2012, 7, 17, 16, 00, 00), PlaceID = 1},
                new Article {ID = 2, Title = "test2", Description = "test2", PostedOn = new DateTime(2012, 7, 17, 16, 1, 1), PlaceID = 2},
            };

            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
            
        }
    }
}
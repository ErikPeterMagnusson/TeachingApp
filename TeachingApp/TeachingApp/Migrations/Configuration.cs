// NAMESPACE START
namespace TeachingApp.Migrations
{
    // SYSTEM LINKAGE
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    // MIGRATION CONNECTION/DIRECTION CLASS
    internal sealed class Configuration : DbMigrationsConfiguration<TeachingApp.DataConnectionlayer.TeachingContext>
    {
        // MIGRATION CONFIGURATION
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        // SEEDING START
        protected override void Seed(TeachingApp.DataConnectionlayer.TeachingContext context)
        {
            // SEED FOR PICTURE
            context.Picture.AddOrUpdate(
                new Models.Picture { ID = 1, Name = "Horse", Word = "Horse" },
                new Models.Picture { ID = 2, Name = "Dog", Word = "Dog" },
                new Models.Picture { ID = 3, Name = "Cat", Word = "Cat" },
                new Models.Picture { ID = 4, Name = "Pig", Word = "Pig" },
                new Models.Picture { ID = 5, Name = "Bird", Word = "Bird" }
                );

            // SEED FOR DIFFERENTIAL TEXT
            context.DifferentialText.AddOrUpdate(
                new Models.DifferentialText { ID = 1, ShowText = "Lorem ipsum dolor sit amet* consectetur adipiscing elit*", GoodText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Models.DifferentialText { ID = 2, ShowText = "Nunc tempus sed lorem quis tincidunt* Morbi magna nibh* suscipit ut sagittis eu* pellentesque non neque*", GoodText = "Nunc tempus sed lorem quis tincidunt. Morbi magna nibh, suscipit ut sagittis eu, pellentesque non neque." },
                new Models.DifferentialText { ID = 3, ShowText = "In consequat tortor quis diam tristique posuere* Proin elit odio* blandit vitae eros sed* tincidunt ullamcorper enim*", GoodText = "In consequat tortor quis diam tristique posuere. Proin elit odio, blandit vitae eros sed, tincidunt ullamcorper enim." },
                new Models.DifferentialText { ID = 4, ShowText = "Lorem ipsum dolor sit amet* consectetur adipiscing elit*", GoodText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Models.DifferentialText { ID = 5, ShowText = "Morbi congue euismod diam* at vestibulum risus pretium in* Duis posuere maximus mauris* sed rutrum lacus convallis vel*", GoodText = "Morbi congue euismod diam, at vestibulum risus pretium in. Duis posuere maximus mauris, sed rutrum lacus convallis vel." }
                );

            // SEED FOR COLOR
            context.Color.AddOrUpdate(
                new Models.Color { ID = 1, ColorText = "Red" },
                new Models.Color { ID = 2, ColorText = "Green" },
                new Models.Color { ID = 3, ColorText = "Blue" },
                new Models.Color { ID = 4, ColorText = "Yellow" },
                new Models.Color { ID = 5, ColorText = "Pink" }
                );

            // SEED FOR SENTENCE
            context.Sentence.AddOrUpdate(
                new Models.Sentence { ID = 1, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Models.Sentence { ID = 2, Text = "Nunc tempus sed lorem quis tincidunt." },
                new Models.Sentence { ID = 3, Text = "Morbi magna nibh, suscipit ut sagittis eu, pellentesque non neque." },
                new Models.Sentence { ID = 4, Text = "In consequat tortor quis diam tristique posuere." },
                new Models.Sentence { ID = 5, Text = "Proin elit odio, blandit vitae eros sed, tincidunt ullamcorper enim." }
                );

            // SEED FOR QUESTION
            context.Question.AddOrUpdate(
                new Models.Question { ID = 1, Text = "What is 1+1?", Answer = "2", Category = "Math", },
                new Models.Question { ID = 2, Text = "Is a dog a bird?", Answer = "No", Category = "Animals", },
                new Models.Question { ID = 3, Text = "What is 3+1?", Answer = "4", Category = "Math", },
                new Models.Question { ID = 4, Text = "What is 4+1?", Answer = "5", Category = "Math", },
                new Models.Question { ID = 5, Text = "What is 5+1?", Answer = "6", Category = "Math", }
                );

            // SEED FOR HIGHSCORE
            context.Highscore.AddOrUpdate(
                new Models.Highscore { ID = 1, Name = "Gyskbarn1", Score = 10 },
                new Models.Highscore { ID = 2, Name = "Gyskbarn2", Score = 9 },
                new Models.Highscore { ID = 3, Name = "Gyskbarn3", Score = 8 },
                new Models.Highscore { ID = 4, Name = "Gyskbarn4", Score = 7 },
                new Models.Highscore { ID = 5, Name = "Gyskbarn5", Score = 6 }
                );
        } // SEEDING END
    } // MIGRATION CONNECTION/DIRECTION END
} // NAMESPACE END

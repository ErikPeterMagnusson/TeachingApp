using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeachingApp.DataConnectionlayer;
using TeachingApp.Models;

namespace TeachingApp.Repositories
{
    public class TeachingRepository
    {
        private TeachingContext context;

        public TeachingRepository()
        {
            context = new TeachingContext();
        }

        public Picture GetPictureById(int id)
        {
            return context.Picture.Single(i => i.ID == id);
        }

        public DifferentialText GetDifferentialTextById(int id)
        {
            return context.DifferentialText.Single(i => i.ID == id);
        }

        public Color GetColorById(int id)
        {
            return context.Color.Single(i => i.ID == id);
        }

        public Sentence GetSentenceById(int id)
        {
            return context.Sentence.Single(i => i.ID == id);
        }

        public Question GetQuestionById(int id)
        {
            return context.Question.Single(i => i.ID == id);
        }

        public Highscore GetHighscoreById(int id)
        {
            return context.Highscore.Single(i => i.ID == id);
        }

        public IEnumerable<Highscore> GetHighscores()
        {
            return context.Highscore.ToList();
        }

        //todo: Add more convenient methods
    }
}
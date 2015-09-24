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

        #region Picture Methods
        public Picture GetPictureById(int id)
        {
            return context.Picture.Single(i => i.ID == id);
        }

        public bool ComparePicture(int id, string inputWord)
        {
            if (inputWord == context.Picture.Single(i => i.ID == id).Word)
                return true;
            else
                return false;
        }
        #endregion

        #region DifferentialText Methods
        public DifferentialText GetDifferentialTextById(int id)
        {
            return context.DifferentialText.Single(i => i.ID == id);
        }

        public bool CompareDifferentialInput(int id, string differentialInput)
        {
            if (differentialInput == context.DifferentialText.Single(i => i.ID == id).GoodText)
                return true;
            else
                return false;
        }
        #endregion

        #region Color Methods
        public Color GetColorById(int id)
        {
            return context.Color.Single(i => i.ID == id);
        }

        public IEnumerable<Color> GetColors()
        {
            return context.Color.ToList();
        }
        #endregion

        #region Sentence Methods
        public Sentence GetSentenceById(int id)
        {
            return context.Sentence.Single(i => i.ID == id);
        }
        public bool CompareSentence(int id, string inputSentence)
        {
            if (inputSentence == context.Sentence.Single(i => i.ID == id).Text)
                return true;
            else
                return false;
        }
        #endregion

        #region Question Methods
        public Question GetQuestionById(int id)
        {
            return context.Question.Single(i => i.ID == id);
        }
        #endregion

        #region Highscore Methods
        public Highscore GetHighscoreById(int id)
        {
            return context.Highscore.Single(i => i.ID == id);
        }

        public IEnumerable<Highscore> GetHighscores()
        {
            return context.Highscore.ToList();
        }
        #endregion

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeachingApp.DataConnectionlayer;
using TeachingApp.Models;
using System.Text.RegularExpressions;


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
            if (inputWord.ToLower() == context.Picture.Single(i => i.ID == id).Word.ToLower())
                return true;
            else
                return false;
        }
        #endregion

        #region DifferentialText Methods

        public IEnumerable<DifferentialText> GetAllDifferentialTexts()
        {
            return context.DifferentialText.ToList();
        }
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
            var h = context.Sentence.Single(i => i.ID == id).Text;
            if (inputSentence == context.Sentence.Single(i => i.ID == id).Text)
                return true;
            else
                return false;
        }
        public Sentence ScrambleSentence(int id, string inputSentence)
        {
            if (inputSentence == context.Sentence.Single(i => i.ID == id).Text)
            {
                char[] separator = new char[] { ' ', ',', '.', '\n', '\r', '\t' };
                string[] elements = inputSentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                Random random = new Random();

                string[] scElements = elements.OrderBy(r => random.Next()).ToArray();

                Sentence sentence = new Sentence();
                sentence.ID = id;
                foreach (string s in scElements)
                {
                    sentence.Text += s + " ";
                }

                return sentence;
            }
            return new Sentence();
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

        public Highscore GetHighscoreByName(string name)
        {
            return context.Highscore.Single(n => n.Name == name);
        }

        public IEnumerable<Highscore> GetHighscores()
        {
            return context.Highscore.ToList();
        }

        public Highscore SetHighscore(int id, int score)
        {
            Highscore NewHighscore = GetHighscoreById(id);
            if (id == 0) return NewHighscore;
            NewHighscore.Score += score;
            context.Entry(NewHighscore).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

            return NewHighscore;
        }
        #endregion

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
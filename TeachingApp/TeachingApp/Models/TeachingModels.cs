// SYSTEM LINKAGE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// NAMESPACE START
namespace TeachingApp.Models
{
    // DATAMODEL FOR PICTURE
    public class Picture
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Word { get; set; }
    }

    //Viewmodel
    //Innehållande all info för Picture (utom ID?)
    //Och en extra string för det användaren kan vilja skriva
    public class PictureViewModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Word { get; set; }
        public string UserResponse { get; set; }
    }

    // DATAMODEL FOR DIFFERENTIAL TEXT
    public class DifferentialText
    {
        [Key]
        public int ID { get; set; }
        public string ShowText { get; set; }
        public string GoodText { get; set; }
    }
    // DATAMODEL FOR COLOR
    public class Color
    {
        [Key]
        public int ID { get; set; }
        public string ColorText { get; set; }
    }
    public class ColorViewModel
    {
        [Key]
        public int ID { get; set; }
        public string ColorText { get; set; }
        public int UserResponse { get; set; }
    }
    // DATAMODEL FOR SENTENCE
    public class Sentence
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
    }
    //Viewmodel
    //Innehållande all info för Sentence (utom ID?)
    //Och en extra string för det användaren kan vilja skriva
    public class SentenceViewModel
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        public string UserResponseSentence { get; set; }
    }

    // DATAMODEL FOR QUESTION
    public class Question
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
    }
    // DATAMODEL FOR HIGHSCORE
    public class Highscore
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime Submitted { get; set; }
    }
} // NAMESPACE TEACHINGAPP.MODELS END
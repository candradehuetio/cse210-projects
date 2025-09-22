using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scripture
{
    
    //-------------------MEMBER VARIABLES----------------

    private Reference _reference;


    // THIS IS A LIST OF WORD OBJECTS, EVERY WORD IS SPLITTED IN THE CONSTRUCTOR.
    // WHEN DEALING WITH WORD HIDDEN OR NOT HIDDEN, IT WILL CONTAIN ITS OWN VALUE FROM
    // ISHIDDEN VARIABLE FOR EACH WORD, SINCE IT IS AN OBJECT LIST. THIS WAY THE ORIGINAL LIST
    // WHICH IS THIS ONE, WILL NOT BE MODIFIED, THE MAGIC IS IN THE GETDISPLAY METHOD FROM THE WORD CLASS
    // WHICH RETURNS A STRING WHETHER IT IS HIDDEN OR NOT; "_" OR "TEXT..."
    private List<Word> _words = new List<Word>();


    //--------------------CONSTRUCTORS------------------------
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // ADDING TO THE _WORDS LIST, WORD BY WORD AS A WORD OBJECT
        string[] wordArray = text.Split(" ");

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    //-------------------METHODS-----------------------------

    public void HideRandomWords(int numberToHide)
    {
        // RANDOM OBJECT TO SELECT A RANDOM NUMBER
        Random random = new Random();

        List<Word> visibleWords = new List<Word>();

        //FIRST LOOP ALL WORDS TO VISIBLE
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        //ENSURES THAT IT DOESNT HIDES A LARGER NUMBER OF VISIBLE WORDS.
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        // LOOOP FOR REMOVING WORDS
        for (int i = 0; i < wordsToHide; i++)
        {
            // USING RANDOM INDEX TO TAKE OUT THE WORD FROM VISIBLE WORDS
            int index = random.Next(visibleWords.Count());

            Word selected = visibleWords[index];
            selected.Hide();

            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string verseText = "";
        foreach (Word w in _words)
        {
            // THIS CONCATENATION WILL STORE THE PAST WORDS, AND THEN ADDS THE
            // CURRENT WORD PLUS SPACE DURING LOOPING
            verseText = verseText + w.GetDisplayText() + " ";
        }

        verseText = verseText.TrimEnd();
        return _reference.GetDisplayText() + " - " + verseText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            // IF THE WORD IS NOT HIDDEN, OR IT IS SHOWING RETURN FALSE
            if (!w.IsHidden())
            {
                return false;
            }
        }
        // IF NO WORD IS SHOWING, RETURN TRUE
        return true;

    }
}
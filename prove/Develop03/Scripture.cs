using System;

public class Scripture
{
    private List<Word> _words;

    public string GetScripture()
    {
        string scripture = null;
        foreach (Word word in _words)
        {
            if (word.GetHidden() == true)
                {scripture += " _ ";}
            else
                {scripture += $" {word}";}
        }
        return scripture;
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetHidden() == false)
            {return false;}
        }

        return true;
    }

    public void HideRandomWords()
    {
        
    }
}
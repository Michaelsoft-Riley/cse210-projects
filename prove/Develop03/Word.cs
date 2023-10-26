using System;

public class Word
{
    private string _word;
    private bool _hidden;

    public void Show()
    {
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public bool GetHidden()
    {
        return _hidden;
    }
}
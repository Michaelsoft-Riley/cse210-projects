using System;

public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string wordText)
    {
        _text = wordText;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
}
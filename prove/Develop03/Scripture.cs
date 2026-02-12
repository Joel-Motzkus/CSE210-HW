using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rand;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        _rand = new Random();

        string[] pieces = text.Split(" ");

        for (int i = 0; i < pieces.Length; i++)
        {
            _words.Add(new Word(pieces[i]));
        }
    }

    public void HideRandomWords(int amount)
    {
        int tries = 0;

        for (int i = 0; i < amount; i++)
        {
            while (true)
            {
                tries = tries + 1;

                int index = _rand.Next(0, _words.Count);

                _words[index].Hide();

                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string output = "";
        output = output + _reference.GetDisplayText();
        output = output + "\n";

        for (int i = 0; i < _words.Count; i++)
        {
            output = output + _words[i].GetDisplayText();
            output = output + " ";
        }

        if (output.Length > 0)
        {
            output = output.Trim();
        }

        return output;
    }

    public bool IsCompletelyHidden()
    {
        int hiddenCount = 0;

        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == true)
            {
                hiddenCount = hiddenCount + 1;
            }
        }

        if (hiddenCount == _words.Count)
        {
            return true;
        }

        return false;
    }
}

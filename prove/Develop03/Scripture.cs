using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden)
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReferenceText());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
}


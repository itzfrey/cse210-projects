using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsToHide = Math.Min(numberToHide, _words.Count(word => !word.IsHidden()));

        // Get indices of words not hidden yet
        var notHiddenIndices = _words
            .Select((word, index) => new { word, index })
            .Where(x => !x.word.IsHidden())
            .Select(x => x.index)
            .ToList();

        // Randomly pick words to hide from those not hidden yet
        var indicesToHide = notHiddenIndices
            .OrderBy(x => Guid.NewGuid())
            .Take(wordsToHide)
            .ToList();

        foreach (int index in indicesToHide)
        {
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}

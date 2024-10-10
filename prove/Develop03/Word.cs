public class Word
{
    private string _wordText;
    private bool _isHidden;

    public Word(string word)
    {
        _wordText = word;
        _isHidden = false;
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "____" : _wordText;
    }
}

